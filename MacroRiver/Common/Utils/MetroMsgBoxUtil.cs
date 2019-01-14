using MetroFramework;
using System;
using System.Windows.Forms;

namespace MacroRiver.Common.Utils
{
    public class MetroMsgBoxUtil
    {
        public static DialogResult Confirm(IWin32Window owner, string text)
        {
            return MetroMessageBox.Show(owner, text, String.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
       
        public static DialogResult Success(IWin32Window owner, string text, string title)
        {
            return MetroMessageBox.Show(owner, text, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        
        public static DialogResult Fail(IWin32Window owner, string text, string title)
        {
            return MetroMessageBox.Show(owner, text, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public static DialogResult Warning(IWin32Window owner, string text, string title)
        {
            return MetroMessageBox.Show(owner, text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
