using System;
using System.Windows.Forms;

namespace MacroRiver.Common.Utils
{
    public class MsgBoxUtil
    {
        public static DialogResult Confirm(string text)
        {
            return MessageBox.Show(text, String.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }

        public static DialogResult Success()
        {
            return Success("操作成功");
        }

        public static DialogResult Success(string text)
        {
            return MessageBox.Show(text, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult Fail()
        {
            return MessageBox.Show("操作未成功", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult Fail(string text)
        {
            return MessageBox.Show(text, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public static DialogResult Warning(string text)
        {
            return MessageBox.Show(text, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
