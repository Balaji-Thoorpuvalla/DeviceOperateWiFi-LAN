using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDemo
{
    public class Seperator : GroupBox
    {
        // Methods
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, 3, specified);
        }

        // Properties
        [DefaultValue("")]
        public override string Text
        {
            get
            {
                return string.Empty;
            }
            set
            {
            }
        }
    }
}
