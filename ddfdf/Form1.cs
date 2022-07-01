using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddfdf
{
    public partial class Form1 : MaterialForm
    {
        //random
        private readonly Random rand = new Random();
        //Timers
        //static readonly System.Windows.Forms.Timer TimerStart = new System.Windows.Forms.Timer();
        private bool getDie = false;
        private int day_to_end_food = 3;
        private GenerateEvents events = new GenerateEvents();
        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen100, TextShade.WHITE);
            
            materialLabel1.Text = $"День {DataBank.day + 1}";
            DataBank.day++;
            LabelGold.Text = "Золото: " + DataBank.gold;
            LabelWood.Text = "Дерево: " + DataBank.wood;
            LabelStone.Text = "Камень: " + DataBank.stone;
            LabelHuman.Text = "Население: " + DataBank.human;
            LabelFood.Text = "Провизия: " + DataBank.food;
            LabelMinusFood.Text = "- " + DataBank.minusFood;
            LabelMoves.Text = "Ходов осталось: " + DataBank.moves;
            LabelFreeWorker.Text = "Свободных: " + DataBank.freeHuman;
            //Timers
        }
        
        public static Task<object> GetTaskFromEvent(object o, string evt)
        {
            if (o == null || evt == null) throw new ArgumentNullException("Arguments cannot be null");

            EventInfo einfo = o.GetType().GetEvent(evt);
            if (einfo == null)
            {
                throw new ArgumentException(String.Format("*{0}* has no *{1}* event", o, evt));
            }

            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            MethodInfo mi = null;
            Delegate deleg = null;
            EventHandler handler = null;

            //код обработчика события
            handler = (s, e) =>
            {
                mi = handler.Method;
                deleg = Delegate.CreateDelegate(einfo.EventHandlerType, handler.Target, mi);
                einfo.RemoveEventHandler(s, deleg); //отцепляем обработчик события
                tcs.TrySetResult(null); //сигнализируем о наступлении события
            };

            mi = handler.Method;
            deleg = Delegate.CreateDelegate(einfo.EventHandlerType, handler.Target, mi); //получаем делегат нужного типа
            einfo.AddEventHandler(o, deleg); //присоединяем обработчик события
            return tcs.Task;
        } // Wait close form


        //Day counter
        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = "День " + (DataBank.day + 1);
            DataBank.day++;
            if(DataBank.day % 4 == 0) //every 4 days new event
                events.Generate();
            if(DataBank.day % 3 == 0 && DataBank.NalogReady == true)
            {
                ClearMsg();
                double nalogPlus;
                nalogPlus = DataBank.human * DataBank.currentNalog;
                DataBank.gold += nalogPlus;
                LabelMsg.Text = $"Поступление с налогов: {nalogPlus}";
                addNewMsg(LabelMsg.Text);
                
            }
            HumansUp();
            UpdateInfo(true);
            if (DataBank.food >= DataBank.human)
            {
                getDie = false;
                day_to_end_food = 3;
                DataBank.count_days_to_die = 0;
            }
            if (DataBank.food < DataBank.human)
            {
                if (DataBank.count_days_to_die >= 3 || DataBank.food <= 0)
                {
                    EndGame();
                    return;
                }
                MessageBox.Show($"Ваши люди голодают. Необходимо добыть провизию.\nУ вас есть {day_to_end_food} дн., чтобы восстановить добычу провизии.");
                day_to_end_food--;
                getDie = true;
            }
            if (getDie)
                DataBank.count_days_to_die++;
        }

        private void addNewMsg(string msg)
        {
            DataBank.msgList.Add($"День: {DataBank.day} | {msg}");
        }

        private void HumansUp()
        {
            int chance = rand.Next(1, 100);
            if (DataBank.food > DataBank.human && DataBank.day % 7 == 0) // every 7 days and if food > humans new "child"
            {
                int newHuman = rand.Next(1, DataBank.human / 4);
                DataBank.human += newHuman;
                LabelMsg.Text = $"В вашем поселении появилось на свет {newHuman} чел.";
                addNewMsg(LabelMsg.Text);
                return;
            }
            else if (chance <= 10 && DataBank.human >= 10) 
            {
                int dieHuman = rand.Next(1, DataBank.human / 6); // if chance <= 10% so some human will die
                DataBank.human -= dieHuman;
                LabelMsg.Text = $"В вашем поселении умерло от старости {dieHuman} чел.";
                addNewMsg(LabelMsg.Text);

            }
            else
            {
                //ClearMsg();
            }
        }

        private void ClearMsg()
        {
            LabelMsg.Text = "Нет новых сообщений";
        }

        private void EndGame()
        {
            DialogResult result = MessageBox.Show("Начать новую игру?", "Игра окончена", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                //DataBank.SetDefault();
                //UpdateInfo(true);
                Application.Restart();
            }
            if(result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void BuildBuildings()
        {
            if (DataBank.isShopBuild == true && ButtonShop.Visible == false)
                ButtonShop.Visible = true;
            if (DataBank.isCityHallBuild == true && ButtonCityHall.Visible == false)
                ButtonCityHall.Visible = true;
            if (DataBank.isBankBuild == true && ButtonBank.Visible == false)
                ButtonBank.Visible = true;
            if (DataBank.isBarracksBuild == true && ButtonBarracks.Visible == false)
                ButtonBarracks.Visible = true;
            if (DataBank.isForgeBuild == true && ButtonForge.Visible == false)
                ButtonForge.Visible = true;
        }

        private void UpdateInfo(bool mainUpdate)
        {
            LabelGold.Text = "Золото: " + DataBank.gold;
            LabelWood.Text = "Дерево: " + DataBank.wood;
            LabelStone.Text = "Камень: " + DataBank.stone;
            LabelHuman.Text = "Население: " + DataBank.human;
            LabelFreeWorker.Text = "Свободных: " + DataBank.freeHuman;
            BuildBuildings();
            if (mainUpdate)
            {
                DataBank.food -= DataBank.minusFood;
                LabelFood.Text = "Провизия: " + DataBank.food;
                DataBank.moves = 5;
                DataBank.freeHuman = DataBank.human;
                DataBank.minusFood = DataBank.human;
                LabelMoves.Text = "Ходов осталось: " + DataBank.moves;
                LabelFreeWorker.Text = "Свободных: " + DataBank.freeHuman;
                LabelMinusFood.Text = "- " + DataBank.minusFood;
                //materialLabel1.Text = "День " + DataBank.day;
                // Turn all buttons to enable
                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(MaterialButton))
                    {
                        control.Enabled = true;
                    }
                }
            }
            else
            {
                LabelFood.Text = "Провизия: " + DataBank.food;
                DataBank.moves--;
                LabelMoves.Text = "Ходов осталось: " + DataBank.moves;
            }
        }
        private bool FreeMoves()
        {
            if(DataBank.moves == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool FreeWorker()
        {
            if (DataBank.freeHuman == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void ButtonFood_Click(object sender, EventArgs e)
        {
            if (FreeWorker())
            {
                if (FreeMoves())
                {
                    FormFood frmFood = new FormFood();
                    frmFood.Show();
                    await GetTaskFromEvent(frmFood, "FormClosed"); // wait event "close form"
                    if (DataBank.isReadyToFood)
                    {
                        int value = rand.Next(1, 100);
                        double upgrade_state = 1;
                        if (DataBank.upgrades["Farm"].Equals(1))
                            upgrade_state = 1.15;
                        else if (DataBank.upgrades["Farm"].Equals(2))
                            upgrade_state = 1.25;
                        else if (DataBank.upgrades["Farm"].Equals(3))
                            upgrade_state = 1.35;

                        double getFood;
                        if (value <= 15)
                        {
                            getFood = DataBank.humantowork + (DataBank.humantowork * 0.7) * upgrade_state;
                            DataBank.food += getFood;
                        }
                        else if (value <= 30)
                        {
                            getFood = DataBank.humantowork * 2.5 * upgrade_state;
                            DataBank.food += getFood;
                        }
                        else
                        {
                            getFood = DataBank.humantowork * 1.8 * upgrade_state;
                            DataBank.food += getFood;
                        }
                        MessageBox.Show("Ваши люди добыли " + getFood + " ед. провизии.");
                        UpdateInfo(false);
                        ButtonFood.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Не осталось ходов.");
                }
            }
            else
            {
                MessageBox.Show("Нет свободных людей.");
            }
        }

        private async void ButtonWood_Click(object sender, EventArgs e)
        {
            if (FreeWorker())
            {
                if (FreeMoves())
                {
                    FormWood frmFood = new FormWood();
                    frmFood.Show();
                    await GetTaskFromEvent(frmFood, "FormClosed"); // wait event "close form"
                    if (DataBank.isReadyToWood)
                    {
                        int value = rand.Next(1, 100);
                        // smwill upgrades
                        double upgrade_state = 1;
                        if (DataBank.upgrades["Sawmill"].Equals(1))
                            upgrade_state = 1.1;
                        else if (DataBank.upgrades["Sawmill"].Equals(2))
                            upgrade_state = 1.2;
                        else if (DataBank.upgrades["Sawmill"].Equals(3))
                            upgrade_state = 1.3;
                        double getFood;
                        if (value <= 15)
                        {
                            getFood = DataBank.humantowork + (DataBank.humantowork * 0.5) * 5 * upgrade_state;
                            DataBank.wood += getFood;
                        }
                        else if (value <= 30)
                        {
                            getFood = DataBank.humantowork * 1.2 * 5 * upgrade_state;
                            DataBank.wood += getFood;
                        }
                        else
                        {
                            getFood = DataBank.humantowork * 5 * upgrade_state;
                            DataBank.wood += getFood;
                        }
                        MessageBox.Show("Ваши люди добыли " + getFood + " ед. дерева.");
                        UpdateInfo(false);
                        ButtonWood.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Не осталось ходов.");
                }
            }
            else
            {
                MessageBox.Show("Нет свободных людей.");
            }
        }

        private async void ButtonStone_Click(object sender, EventArgs e)
        {
            if (FreeWorker())
            {
                if (FreeMoves())
                {
                    FormStone frmFood = new FormStone();
                    frmFood.Show();
                    await GetTaskFromEvent(frmFood, "FormClosed"); // wait event "close form"
                    if (DataBank.isReadyToStone)
                    {
                        int value = rand.Next(1, 100);
                        double upgrade_state = 1;
                        if (DataBank.upgrades["Quarry"].Equals(1))
                            upgrade_state = 1.08;
                        else if (DataBank.upgrades["Quarry"].Equals(2))
                            upgrade_state = 1.16;
                        else if (DataBank.upgrades["Quarry"].Equals(3))
                            upgrade_state = 1.24;
                        double getFood;
                        if (value <= 15)
                        {
                            getFood = DataBank.humantowork + (DataBank.humantowork * 0.5) * 3 * upgrade_state;
                            DataBank.stone += getFood;
                        }
                        else if (value <= 30)
                        {
                            getFood = DataBank.humantowork * 1.2 * 3 * upgrade_state;
                            DataBank.stone += getFood;
                        }
                        else
                        {
                            getFood = DataBank.humantowork * 3 * upgrade_state;
                            DataBank.stone += getFood;
                        }
                        MessageBox.Show("Ваши люди добыли " + getFood + " ед. камня.");
                        UpdateInfo(false);
                        ButtonStone.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Не осталось ходов.");
                }
            }
            else
            {
                MessageBox.Show("Нет свободных людей.");
            }
        }

        private async void ButtonBuildings_Click(object sender, EventArgs e)
        {
            FormBuildings frm = new FormBuildings();
            frm.Show();
            await GetTaskFromEvent(frm, "FormClosed");
            UpdateInfo(false);
        }

        private async void ButtonCityHall_Click(object sender, EventArgs e)
        {
            Form frm = new CityHallForm();
            frm.Show();
            await GetTaskFromEvent(frm, "FormClosed");
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            Form form = new AllMsgForm();
            form.Show();
        }
    }
}
