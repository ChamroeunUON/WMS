using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMessage
{
    public class MyMessage
    {
        public static void showMessage(String s)
        {

            MessageBox.Show(s + " ");
        }   
    }
}
