using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace MacroRiver
{
    public partial class UCHome : MetroUserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var ucNext = new UCConnection();
            ucNext.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(ucNext);
            this.Parent.Controls.Remove(this);
        }
    }
}
