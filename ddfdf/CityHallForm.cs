using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace ddfdf
{
    public partial class CityHallForm : Form
    {
        public CityHallForm()
        {
            InitializeComponent();
            if (DataBank.state_upgrade[6] == 2)
                DataBank.maxNalog = 5; // 7 9
            if (DataBank.state_upgrade[6] == 3)
                DataBank.maxNalog = 7;
            if (DataBank.state_upgrade[6] == 4)
                DataBank.maxNalog = 9;
            LabelCurrentNalog.Text = "Текущий налог: " + DataBank.currentNalog.ToString();
            LabelMaxNalog.Text = "Маскимально возможный налог: " + DataBank.maxNalog.ToString();
            SliderSetNalog.RangeMax = DataBank.maxNalog;
            SliderSetNalog.RangeMin = 0;
            SliderSetNalog.Value = DataBank.currentNalog;
            SliderSetNalog.Text = "Установить налог";
        }

        private void ButtonConfirm_Click(object sender, System.EventArgs e)
        {
            if (DataBank.currentNalog > 0)
                DataBank.NalogReady = true;
            this.Close();
        }

        private void SliderSetNalog_MouseUp(object sender, MouseEventArgs e)
        {
            DataBank.currentNalog = SliderSetNalog.Value;
        }
    }
}
