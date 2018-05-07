using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMessage
{
    public class Validata
    {
        public static void setDefualtTextBox(TextBox text,
                                             TextBox text1,
                                             TextBox text2,
                                             TextBox text3,
                                             TextBox text4,
                                              TextBox text5
                                                           )
        {
            if (text.Text==null) {
                if (text1.Text == null)
                {
                    if (text2.Text == null)
                    {
                        if (text3.Text == null)
                        {
                            if (text4.Text == null)
                            {
                               if (text5.Text == null)
                                    text5.Text = "N/A";
                            text4.Text = "N/A";
                            }
                        text3.Text = "N/A";                     
                        }
                      text2.Text = "N/A";                             
                    }
                    text1.Text = "N/A";                     
                }
                text3.Text = "N/A";                      
            }

        }
    }
}
