using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Middle
{
    public class MiddleTriangle180 : Shape
    {
        public MiddleTriangle180()
        {
            BackColor = Color.DarkOrange;

            Name = Constants.MiddleTriangle180;
            Type = ShapeTypes.MiddleTriangle;
            Size = new Size(Constants.SquareLength / 2, Constants.SquareLength / 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints180(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new MiddleTriangle225());
            base.OnClick(e);
        }
    }
}
