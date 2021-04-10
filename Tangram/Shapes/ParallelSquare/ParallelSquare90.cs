using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes.ParallelSquare
{
    public class ParallelSquare90 : Shape
    {
        public ParallelSquare90()
        {
            BackColor = Color.Aqua;

            Name = Constants.ParallelSquare90;
            Type = ShapeTypes.ParallelSquare;
            Size = new Size((Constants.SquareLength / 4) * 3, Constants.SquareLength / 4);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new PointF[]
                {
                    new PointF(Constants.LengthUnit ,0),
                    new PointF(Width,0),
                    new PointF( Constants.LengthUnit*2,Height),
                    new PointF(0, Constants.LengthUnit)

                });
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }


        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new ParallelSquareM90());
            base.OnClick(e);
        }
    }
}
