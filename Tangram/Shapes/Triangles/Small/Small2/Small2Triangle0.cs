using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Big.Big1
{
    public class Small2Triangle0 : Shape
    {
        public Small2Triangle0()
        {
            BackColor = Color.Lime;

            Name = Constants.Small2Triangle0;
            Type = ShapeTypes.SmallTriangle2;
            Size = new Size(Constants.Coefficient / 2, Constants.Coefficient / 2);
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
            ShapeManager.SetNextShape(this, new Small2Triangle45());
            base.OnClick(e);
        }
    }
}
