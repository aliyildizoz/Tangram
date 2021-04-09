using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangram.Shapes
{
    public class LevelPair
    {
        public int Level { get; set; }
        public PointF[] Points { get; set; }
        public Size Size { get; set; }
    }
}
