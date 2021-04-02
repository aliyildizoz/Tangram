using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangram.Shapes.Triangles.Big.Big1;

namespace Tangram.Shapes
{
    public class Constants
    {
        public static int SquareLength = 300;
        public static int Coefficient => Convert.ToInt32(Math.Floor(SquareLength / Math.Sqrt(2)));
        //Big1
        public static string Big1Triangle0 = nameof(Big1Triangle0);
        public static string Big1Triangle45 = nameof(Big1Triangle45);
        public static string Big1Triangle90 = nameof(Big1Triangle90);
        public static string Big1Triangle135 = nameof(Big1Triangle135);
        public static string Big1Triangle180 = nameof(Big1Triangle180);
        public static string Big1Triangle225 = nameof(Big1Triangle225);
        public static string Big1Triangle270 = nameof(Big1Triangle270);
        public static string Big1Triangle315 = nameof(Big1Triangle315);
        //Big2
        public static string Big2Triangle0 = nameof(Big2Triangle0);
        public static string Big2Triangle45 = nameof(Big2Triangle45);
        public static string Big2Triangle90 = nameof(Big2Triangle90);
        public static string Big2Triangle135 = nameof(Big2Triangle135);
        public static string Big2Triangle180 = nameof(Big2Triangle180);
        public static string Big2Triangle225 = nameof(Big2Triangle225);
        public static string Big2Triangle270 = nameof(Big2Triangle270);
        public static string Big2Triangle315 = nameof(Big2Triangle315);

        //Small1
        public static string Small1Triangle0 = nameof(Small1Triangle0);
        public static string Small1Triangle45 = nameof(Small1Triangle45);
        public static string Small1Triangle90 = nameof(Small1Triangle90);
        public static string Small1Triangle135 = nameof(Small1Triangle135);
        public static string Small1Triangle180 = nameof(Small1Triangle180);
        public static string Small1Triangle225 = nameof(Small1Triangle225);
        public static string Small1Triangle270 = nameof(Small1Triangle270);
        public static string Small1Triangle315 = nameof(Small1Triangle315);
        //Small2
        public static string Small2Triangle0 = nameof(Small2Triangle0);
        public static string Small2Triangle45 = nameof(Small2Triangle45);
        public static string Small2Triangle90 = nameof(Small2Triangle90);
        public static string Small2Triangle135 = nameof(Small2Triangle135);
        public static string Small2Triangle180 = nameof(Small2Triangle180);
        public static string Small2Triangle225 = nameof(Small2Triangle225);
        public static string Small2Triangle270 = nameof(Small2Triangle270);
        public static string Small2Triangle315 = nameof(Small2Triangle315);

        //Square
        public static string Square0 = nameof(Square0);
        public static string Square45 = nameof(Square45);
    }
}
