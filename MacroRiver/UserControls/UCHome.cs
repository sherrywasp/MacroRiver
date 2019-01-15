using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MacroRiver.UserControls;

namespace MacroRiver.UserControls
{
    public partial class UCHome : MetroUserControl
    {
        public UCHome()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void mBtnStart_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCConnection());
            this.Parent.Controls.Remove(this);
        }
    }
}
