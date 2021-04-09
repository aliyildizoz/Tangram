using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes
{
    public class Level : PictureBox
    {
        public Level()
        {
            BackColor = Color.LightGray;
            Location = Constants.LevelLocation;
            Size = Game.CurrentLevel.Size;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(Game.CurrentLevel.Points);

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

    }
}
