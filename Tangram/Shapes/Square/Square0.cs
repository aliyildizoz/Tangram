using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes.Square
{
    public class Square0 : Shape, ISetFirstLocation
    {
        public Square0()
        {
            BackColor = Color.Red;

            Name = Constants.Square45;
            Type = ShapeTypes.Square;
            Size = new Size(Constants.Coefficient / 2, Constants.Coefficient / 2);
        }
        
        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new Square45());
            base.OnClick(e);
        }

        public void SetFirstLocation()
        {
            ShapeManager.SetNextShape(this, new Square45());
        }
    }
}
