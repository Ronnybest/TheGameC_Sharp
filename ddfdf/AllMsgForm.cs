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
    public partial class AllMsgForm : Form
    {
        public AllMsgForm()
        {
            InitializeComponent();
            for(int i = 0; i < DataBank.msgList.Count(); i++)
            {
                materialListBox1.AddItem(DataBank.msgList[i]);
            }
        }
    }
}
