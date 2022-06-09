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
    
    public partial class FormFood : Form
    {
        public FormFood()
        {
            InitializeComponent();
            materialSlider1.RangeMax = DataBank.freeHuman;
            materialSlider1.RangeMin = 0;
            materialSlider1.Value = 1;
            LabelFreeWorker.Text = "Свободные люди: " + DataBank.freeHuman;
        }

        private void materialSlider1_MouseUp(object sender, MouseEventArgs e)
        {
            DataBank.humantowork = materialSlider1.Value;
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            DataBank.isReadyToFood = true;
            DataBank.freeHuman -= materialSlider1.Value;
            this.Close();
        }
    }
}
