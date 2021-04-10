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
    public class ParallelSquareM0 : Shape
    {
        public ParallelSquareM0()
        {
            BackColor = Color.Aqua;

            Name = Constants.ParallelSquareM0;
            Type = ShapeTypes.ParallelSquare;
            Size = new Size(Constants.SquareLength / 4, (Constants.SquareLength / 4) * 3);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new PointF[]
                {
                    
                    new PointF(0,0 ),
                    new PointF(Width,Width),
                    new PointF( Width,Height),
                    new PointF(0, Constants.SquareLength / 2),


                });
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }


        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new ParallelSquare45());
            base.OnClick(e);
        }
    }
}
