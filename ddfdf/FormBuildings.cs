using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ddfdf
{

    public partial class FormBuildings : Form
    {
        private int upgrade_multip = 4;
        public List<Control> buttons = new List<Control>();
        public FormBuildings()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(MaterialButton))
                    buttons.Add(c);
            }
            setInfo();
            checkPrice();
        }

        void checkPrice()
        {
            BuildingInfo.setDisable(buttons);
        }
        void setInfo()
        {
            for (int i = 0, j = 1; i < DataBank.all_price.Count(); i += 2, j++) 
            {
                this.Controls["ButtonBuilding" + j].Text = "Дерево: " + DataBank.wood + "/" + DataBank.all_price[i] + "\nКамень: " + DataBank.stone + "/" + DataBank.all_price[i + 1] + "\nТекущий уровень: " + (DataBank.state_upgrade[j - 1] - 1);
                setMaxUpgrade(this.Controls["ButtonBuilding" + j], j - 1);
            }
            BuildingInfo.setDisable(buttons);
        }

        bool checkRes(int pos)
        {
            if (DataBank.wood < DataBank.all_price[pos] || DataBank.stone < DataBank.all_price[pos + 1])
            {
                MessageBox.Show("Недостаточно ресурсов");
                return false;
            }
            return true;
        }

        private Control setMaxUpgrade(Control button, int idx)
        {
            if(DataBank.state_upgrade[idx] == 4)
            {
                button.Text = "Максимальный уровень";
                button.Enabled = false;
            }
            return button;
        }

        private void LabelBuilding_1_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(1);
        }

        private void LabelBuilding_2_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(2);
        }

        private void LabelBuilding_3_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(3);
        }

        private void LabelBuilding_4_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(4);
        }

        private void LabelBuilding_5_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(5);
        }

        private void LabelBuilding_6_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(6);
        }

        private void LabelBuilding_7_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(7);
        }

        private void LabelBuilding_8_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(8);
        }

        private void LabelBuilding_9_Click(object sender, EventArgs e)
        {
            BuildingInfo.ShowInfo(9);
        }

        private void ButtonBuilding1_Click(object sender, EventArgs e)
        {
            if (checkRes(0))
            {
                DataBank.upgrades["Sawmill"] = DataBank.state_upgrade[0];
                DataBank.state_upgrade[0]++;
                DataBank.wood -= DataBank.all_price[0];
                DataBank.stone -= DataBank.all_price[1];
                DataBank.all_price[0] *= upgrade_multip;
                DataBank.all_price[1] *= upgrade_multip;
                DataBank.isSawmilBuild = true;
                setInfo();
            }
        }

        private void ButtonBuilding9_Click(object sender, EventArgs e)
        {
            if (checkRes(16))
            {
                DataBank.upgrades["Barracks"] = DataBank.state_upgrade[8];
                DataBank.state_upgrade[8]++;
                DataBank.wood -= DataBank.all_price[16];
                DataBank.stone -= DataBank.all_price[17];
                DataBank.all_price[16] *= upgrade_multip;
                DataBank.all_price[17] *= upgrade_multip;
                DataBank.isBarracksBuild = true;
                setInfo();
            }
        }

        private void ButtonBuilding3_Click(object sender, EventArgs e)
        {
            if (checkRes(4))
            {
                DataBank.upgrades["Farm"] = DataBank.state_upgrade[2];
                DataBank.state_upgrade[2]++;
                DataBank.wood -= DataBank.all_price[4];
                DataBank.stone -= DataBank.all_price[5];
                DataBank.all_price[4] *= upgrade_multip;
                DataBank.all_price[5] *= upgrade_multip;
                DataBank.isFarmBuild = true;
                setInfo();
            }
        }

        private void ButtonBuilding4_Click(object sender, EventArgs e)
        {
            if (checkRes(6))
            {
                DataBank.upgrades["Forge"] = DataBank.state_upgrade[3];
                DataBank.state_upgrade[3]++;
                DataBank.wood -= DataBank.all_price[6];
                DataBank.stone -= DataBank.all_price[7];
                DataBank.all_price[6] *= upgrade_multip;
                DataBank.all_price[7] *= upgrade_multip;
                DataBank.isForgeBuild = true;
                setInfo();
            }
        }

        private void ButtonBuilding5_Click(object sender, EventArgs e)
        {
            if (checkRes(8))
            {
                DataBank.upgrades["Market"] = DataBank.state_upgrade[4];
                DataBank.state_upgrade[4]++;
                DataBank.wood -= DataBank.all_price[8];
                DataBank.stone -= DataBank.all_price[9];
                DataBank.all_price[8] *= upgrade_multip;
                DataBank.all_price[9] *= upgrade_multip;
                DataBank.isShopBuild = true;
                setInfo();
            }
            
        }

        private void ButtonBuilding6_Click(object sender, EventArgs e)
        {
            if (checkRes(10))
            {
                DataBank.upgrades["Bank"] = DataBank.state_upgrade[5];
                DataBank.state_upgrade[5]++;
                DataBank.wood -= DataBank.all_price[10];
                DataBank.stone -= DataBank.all_price[11];
                DataBank.all_price[10] *= upgrade_multip;
                DataBank.all_price[11] *= upgrade_multip;
                DataBank.isBankBuild = true;
                setInfo();
            }
        }

        private void ButtonBuilding7_Click(object sender, EventArgs e)
        {
            if (checkRes(12))
            {
                DataBank.upgrades["City_hall"] = DataBank.state_upgrade[6];
                DataBank.state_upgrade[6]++;
                DataBank.wood -= DataBank.all_price[12];
                DataBank.stone -= DataBank.all_price[13];
                DataBank.all_price[12] *= upgrade_multip;
                DataBank.all_price[13] *= upgrade_multip;
                DataBank.isCityHallBuild = true;
                setInfo();
            }
        }

        private void ButtonBuilding8_Click(object sender, EventArgs e)
        {
            if (checkRes(14))
            {
                DataBank.upgrades["Port"] = DataBank.state_upgrade[7];
                DataBank.state_upgrade[7]++;
                DataBank.wood -= DataBank.all_price[14];
                DataBank.stone -= DataBank.all_price[15];
                DataBank.all_price[14] *= upgrade_multip;
                DataBank.all_price[15] *= upgrade_multip;
                DataBank.isPortBuild = true;
                setInfo();
            }
        }

        private void ButtonBuilding2_Click(object sender, EventArgs e)
        {
            if (checkRes(2))
            {
                DataBank.upgrades["Quarry"] = DataBank.state_upgrade[1];
                DataBank.state_upgrade[1]++;
                DataBank.wood -= DataBank.all_price[2];
                DataBank.stone -= DataBank.all_price[3];
                DataBank.all_price[2] *= upgrade_multip;
                DataBank.all_price[3] *= upgrade_multip;
                DataBank.isQuarryBuild = true;
                setInfo();
            }
        }
    }
}
