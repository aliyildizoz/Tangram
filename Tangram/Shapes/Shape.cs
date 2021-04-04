using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tangram.Shapes
{
    public class Shape : PictureBox
    {
        public bool ignoreClick = false;
        public ShapeTypes Type { get; set; }

        public Shape()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            ignoreClick = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ignoreClick = true;
            }
            base.OnMouseMove(e);
        }
        
    }
}
