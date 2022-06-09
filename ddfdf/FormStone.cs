using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddfdf
{
    public partial class FormStone : Form
    {
        public FormStone()
        {
            InitializeComponent();
            materialSlider1.RangeMax = DataBank.freeHuman;
            materialSlider1.RangeMin = 0;
            materialSlider1.Value = 1;
            LabelFreeWorker.Text = "Свободные люди: " + DataBank.freeHuman;
        }

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            DataBank.isReadyToStone = true;
            DataBank.freeHuman -= materialSlider1.Value;
            this.Close();
        }

        private void materialSlider1_MouseUp(object sender, MouseEventArgs e)
        {
            DataBank.humantowork = materialSlider1.Value;
        }
    }
}
