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
    public partial class UCConnection : MetroUserControl
    {
        public UCConnection()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ucHome = new UCHome();
            ucHome.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(ucHome);
            this.Parent.Controls.Remove(this);
        }
    }
}
