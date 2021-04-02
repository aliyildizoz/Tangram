using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Big.Big1
{
    public class Small1Triangle0 : Shape
    {
        public Small1Triangle0()
        {
            BackColor = Color.Yellow;

            Name = Constants.Small1Triangle0;
            Type = ShapeTypes.SmallTriangle1;
            Size = new Size(Constants.Coefficient * 2, Constants.Coefficient * 2);
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
            ShapeManager.SetNextShape(this, new Small1Triangle45());
            base.OnClick(e);
        }
    }
}
