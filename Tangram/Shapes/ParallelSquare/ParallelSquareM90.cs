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
   public class ParallelSquareM90 : Shape
   {
       public ParallelSquareM90()
       {
           BackColor = Color.Aqua;

           Name = Constants.ParallelSquareM90;
           Type = ShapeTypes.ParallelSquare;
           Size = new Size((Constants.SquareLength / 4) * 3, Constants.SquareLength / 4);

       }
       protected override void OnPaint(PaintEventArgs e)
       {
           using (var grp = new GraphicsPath())
           {
               grp.AddPolygon(new PointF[]
               {
                   new PointF(0,0 ),
                   new PointF(Constants.LengthUnit*2,0),
                   new PointF( Width,Height),
                   new PointF(Constants.LengthUnit, Constants.LengthUnit)

               });
               this.Region = new Region(grp);
           }
           base.OnPaint(e);
       }


        protected override void OnClick(EventArgs e)
       {
           ShapeManager.SetNextShape(this, new ParallelSquare135());
           base.OnClick(e);
       }
   }
}
