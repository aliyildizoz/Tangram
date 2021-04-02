using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Middle
{
    public class MiddleTriangle315 : Shape
    {
        public MiddleTriangle315()
        {
            BackColor = Color.DarkOrange;

            Name = Constants.MiddleTriangle315;
            Type = ShapeTypes.MiddleTriangle;
            Size = new Size(Constants.Coefficient , Constants.Coefficient );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints315(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }


        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new MiddleTriangle0());
            base.OnClick(e);
        }
    }
}
