using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMessage
{
    public class setStaeButtonControl
    {
       
        public void setButtonStateEnable(ToolStripButton Cancel, ToolStripButton Edit, ToolStripButton Delete, ToolStripButton Save)
        {
            Cancel.Enabled=true;
            Edit.Enabled=true;
            Delete.Enabled=true;
            Save.Enabled = true;
            
        }
        public void setButtonStateDisable(ToolStripButton Cancel, ToolStripButton Edit, ToolStripButton Delete, ToolStripButton Save)
        {
           
            Cancel.Enabled = false;
            Edit.Enabled = false;
            Delete.Enabled = false;
            Save.Enabled = false;
           
        }

        
    }
}
