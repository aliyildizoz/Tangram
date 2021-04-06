using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Middle
{
    public class MiddleTriangle90 : Shape
    {
        public MiddleTriangle90()
        {
            BackColor = Color.DarkOrange;

            Name = Constants.MiddleTriangle90;
            Type = ShapeTypes.MiddleTriangle;
             Size = new Size(Constants.SquareLength / 2, Constants.SquareLength / 2);
            Location = new Point(Constants.FirstLocation.X + +Constants.SquareLength / 2, Constants.FirstLocation.Y + Constants.SquareLength / 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints90(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new MiddleTriangle135());
            base.OnClick(e);
        }
    }
}
