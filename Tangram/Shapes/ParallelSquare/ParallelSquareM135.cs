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
    public class ParallelSquareM135 : Shape
    {
        public ParallelSquareM135()
        {
            BackColor = Color.Aqua;

            Name = Constants.ParallelSquareM135;
            Type = ShapeTypes.ParallelSquare;
            Size = new Size(Constants.CoefficientUnit * 2, Constants.CoefficientUnit);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new PointF[]
                {
                    new PointF(0,0 ),
                    new PointF(Height,0),
                    new PointF(Width,Height),
                    new PointF( Height,Height)


                });
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new ParallelSquare0());
            base.OnClick(e);
        }
    }
}
