using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Middle
{
    public class MiddleTriangle270 : Shape
    {
        public MiddleTriangle270()
        {
            BackColor = Color.DarkOrange;

            Name = Constants.MiddleTriangle270;
            Type = ShapeTypes.MiddleTriangle;
            Size = new Size(Constants.SquareLength/2 , Constants.SquareLength / 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints270(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new MiddleTriangle315());
            base.OnClick(e);
        }
    }
}
