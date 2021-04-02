using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tangram.Shapes.Triangles.Big.Big1;

namespace Tangram.Shapes.Triangles.Big.Big2
{
    public class Big2Triangle0 : Shape
    {
        public Big2Triangle0()
        {
            BackColor = Color.HotPink;

            Name = Constants.Big2Triangle0;
            Type = ShapeTypes.BigTriangle2;
            Size = new Size(Constants.Coefficient, Constants.Coefficient);

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
            ShapeManager.SetNextShape(this, new Big2Triangle45());
            base.OnClick(e);
        }
    }
}
