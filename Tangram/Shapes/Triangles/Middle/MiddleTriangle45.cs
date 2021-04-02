using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Middle
{
    public class MiddleTriangle45 : Shape
    {
        public MiddleTriangle45()
        {
            BackColor = Color.DarkOrange;
            Name = Constants.MiddleTriangle45;
            Type = ShapeTypes.MiddleTriangle;
            Size = new Size(Constants.Coefficient, Constants.Coefficient );
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints45(Size.Height));
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new MiddleTriangle90());
            base.OnClick(e);
        }


    }
}
