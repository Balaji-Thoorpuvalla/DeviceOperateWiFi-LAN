using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDemo
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {

            GraphicsPath gpPath = new GraphicsPath();
            gpPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(gpPath);
            base.OnPaint(pevent);
            
        }
    }
}
