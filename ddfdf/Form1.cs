using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddfdf
{
    public partial class Form1 : MaterialForm
    {
        //random
        Random rand = new Random();
        //Timers
        static System.Windows.Forms.Timer TimerStart = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen100, TextShade.WHITE);
            materialLabel1.Text = "День " + DataBank.day;
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
            TimerStart.Tick += new EventHandler(tm_Tick);
            TimerStart.Interval = 1000;
            TimerStart.Start();
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

        private void tm_Tick(object sender, EventArgs e)
        {
            if (DataBank.food < DataBank.human)
            {
                TimerStart.Stop();
                MessageBox.Show("Ваши люди голодают. Необходимо добыть провизию.");
            }
        }

        //Day counter
        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = "День " + DataBank.day;
            DataBank.day++;
            UpdateInfo(sender, e, true);
            TimerStart.Start();
        }
        private void UpdateInfo(object sender, EventArgs e, bool mainUpdate)
        {
            LabelGold.Text = "Золото: " + DataBank.gold;
            LabelWood.Text = "Дерево: " + DataBank.wood;
            LabelStone.Text = "Камень: " + DataBank.stone;
            LabelHuman.Text = "Население: " + DataBank.human;
            LabelFreeWorker.Text = "Свободных: " + DataBank.freeHuman;
            if (mainUpdate)
            {
                DataBank.food -= DataBank.minusFood;
                LabelFood.Text = "Провизия: " + DataBank.food;
                DataBank.moves = 5;
                DataBank.freeHuman = DataBank.human;
                LabelMoves.Text = "Ходов осталось: " + DataBank.moves;
                LabelFreeWorker.Text = "Свободных: " + DataBank.freeHuman;
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
                        double getFood = 0;
                        int value = rand.Next(1, 100);
                        if (value <= 15)
                        {
                            getFood = DataBank.humantowork + (DataBank.humantowork * 0.5);
                            DataBank.food += getFood;
                        }
                        else if (value <= 30)
                        {
                            getFood = DataBank.humantowork * 1.5;
                            DataBank.food += getFood;
                        }
                        else
                        {
                            getFood = DataBank.humantowork * 1.2;
                            DataBank.food += getFood;
                        }
                        MessageBox.Show("Ваши люди добыли " + getFood + " ед. провизии.");
                        UpdateInfo(sender, e, false);
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
                        double getFood = 0;
                        int value = rand.Next(1, 100);
                        if (value <= 15)
                        {
                            getFood = DataBank.humantowork + (DataBank.humantowork * 0.5) * 5;
                            DataBank.wood += getFood;
                        }
                        else if (value <= 30)
                        {
                            getFood = DataBank.humantowork * 1.2 * 5;
                            DataBank.wood += getFood;
                        }
                        else
                        {
                            getFood = DataBank.humantowork * 5;
                            DataBank.wood += getFood;
                        }
                        MessageBox.Show("Ваши люди добыли " + getFood + " ед. дерева.");
                        UpdateInfo(sender, e, false);
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
                        double getFood = 0;
                        int value = rand.Next(1, 100);
                        if (value <= 15)
                        {
                            getFood = DataBank.humantowork + (DataBank.humantowork * 0.5) * 3;
                            DataBank.stone += getFood;
                        }
                        else if (value <= 30)
                        {
                            getFood = DataBank.humantowork * 1.2 * 3;
                            DataBank.stone += getFood;
                        }
                        else
                        {
                            getFood = DataBank.humantowork * 3;
                            DataBank.stone += getFood;
                        }
                        MessageBox.Show("Ваши люди добыли " + getFood + " ед. камня.");
                        UpdateInfo(sender, e, false);
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
            UpdateInfo(sender, e, false);
        }
    }
}
