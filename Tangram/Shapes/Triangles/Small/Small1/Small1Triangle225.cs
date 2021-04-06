using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Small.Small1
{
    public class Small1Triangle225 : Shape
    {
        public Small1Triangle225()
        {
            BackColor = Color.Yellow;

            Name = Constants.Small1Triangle225;
            Type = ShapeTypes.SmallTriangle1;
            Size = new Size(Constants.SquareLength / 2, Constants.SquareLength / 2);
            Location = new Point(Constants.FirstLocation.X , Constants.FirstLocation.Y + Constants.SquareLength - Constants.SquareLength / 4);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints225(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new Small1Triangle270());
            base.OnClick(e);
        }
    }
}
