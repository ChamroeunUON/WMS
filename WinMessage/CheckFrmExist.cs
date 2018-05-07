using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMessage
{
    public class CheckFrmExist
    {
        public static bool frmExist(Form form)
        {
            FormCollection frmC = Application.OpenForms;
            foreach (Form frm in frmC)
            {
                if (frm.GetType() == form.GetType())
                {
                    form.Dispose();
                    form.Focus();
                    return true;
                }
            }
            return false;
        }
    }
}
