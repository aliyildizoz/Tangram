using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Middle
{
    public class MiddleTriangle0 : Shape
    {
        public MiddleTriangle0()
        {
            BackColor = Color.DarkOrange;

            Name = Constants.MiddleTriangle0;
            Type = ShapeTypes.MiddleTriangle;
            Size = new Size(Constants.SquareLength / 2, Constants.SquareLength / 2);
         
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints0(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new MiddleTriangle45());
            base.OnClick(e);
        }
    }
}
