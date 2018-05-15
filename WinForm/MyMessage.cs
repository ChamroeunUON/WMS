using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public static class MyMessage
    {
        public static DialogResult Warning(string msg)
        {
            return MessageBox.Show(msg, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Success(string msg)
        {
            return MessageBox.Show(msg, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult Error(string msg)
        {
            return MessageBox.Show(msg, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
