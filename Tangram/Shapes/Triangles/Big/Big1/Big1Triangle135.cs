﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Big.Big1
{
    public class Big1Triangle135 : Shape
    {
        public Big1Triangle135()
        {
            BackColor = Color.Blue;

            Name = Constants.Big1Triangle135;
            Type = ShapeTypes.BigTriangle1;
            Size = new Size( Constants.SquareLength,  Constants.SquareLength);
            Location = Constants.ShapesFirstLocation;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints135(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new Big1Triangle180());
            base.OnClick(e);
        }
    }
}
