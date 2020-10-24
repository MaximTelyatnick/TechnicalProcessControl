using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalProcessControl.CustomView
{
    class ToolStripMenuItemCustom : ToolStripMenuItem, ICloneable
    {
        public string Text { get; set; }
        public Image Image { get; set; }
        public string ToolTipText { get; set; } 
        public object Tag { get; set; } 


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
