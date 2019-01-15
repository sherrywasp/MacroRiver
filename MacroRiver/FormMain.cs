using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace MacroRiver
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MsgBoxUtil.Confirm("确定退出？") != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
