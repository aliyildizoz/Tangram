using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tangram.Shapes.Triangles.Big.Big1;

namespace Tangram.Shapes.Triangles.Small.Small1
{
    public class Small1Triangle270 : Shape
    {
        public Small1Triangle270()
        {
            BackColor = Color.Yellow;

            Name = Constants.Small1Triangle270;
            Type = ShapeTypes.SmallTriangle1;
            Size = new Size(Constants.Coefficient / 2, Constants.Coefficient / 2);
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
            ShapeManager.SetNextShape(this, new Small1Triangle315());
            base.OnClick(e);
        }
    }
}
