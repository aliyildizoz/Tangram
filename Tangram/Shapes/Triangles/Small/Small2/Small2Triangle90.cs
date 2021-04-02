using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Small.Small2
{
    public class Small2Triangle90 : Shape
    {
        public Small2Triangle90()
        {
            BackColor = Color.Lime;

            Name = Constants.Small2Triangle90;
            Type = ShapeTypes.SmallTriangle2;
            Size = new Size(Constants.Coefficient / 2, Constants.Coefficient / 2);
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
            ShapeManager.SetNextShape(this, new Small2Triangle135());
            base.OnClick(e);
        }
    }
}
