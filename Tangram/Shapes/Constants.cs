﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangram.Shapes.Triangles.Big.Big1;

namespace Tangram.Shapes
{
    public class Constants
    {
        public static int SquareLength = 300;
        public static Point ShapesFirstLocation = new Point(100, 100);
        public static Point LevelLocation = new Point(450, 100);
        public static int LengthUnit = SquareLength / 4;

        public static int Coefficient => Convert.ToInt32(Math.Floor(SquareLength / Math.Sqrt(2)));
        public static int CoefficientUnit => Convert.ToInt32(Math.Floor((SquareLength * Math.Sqrt(2)))) / 4;
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

        //Middle
        public static string MiddleTriangle0 = nameof(MiddleTriangle0);
        public static string MiddleTriangle45 = nameof(MiddleTriangle45);
        public static string MiddleTriangle90 = nameof(MiddleTriangle90);
        public static string MiddleTriangle135 = nameof(MiddleTriangle135);
        public static string MiddleTriangle180 = nameof(MiddleTriangle180);
        public static string MiddleTriangle225 = nameof(MiddleTriangle225);
        public static string MiddleTriangle270 = nameof(MiddleTriangle270);
        public static string MiddleTriangle315 = nameof(MiddleTriangle315);

        //Square
        public static string Square0 = nameof(Square0);
        public static string Square45 = nameof(Square45);

        //ParallelSquare
        public static string ParallelSquare0= nameof(ParallelSquare0);
        public static string ParallelSquare45 = nameof(ParallelSquare45);
        public static string ParallelSquare90 =  nameof(ParallelSquare90);
        public static string ParallelSquare135 = nameof(ParallelSquare135);
        public static string ParallelSquareM90 = nameof(ParallelSquareM90);
        public static string ParallelSquareM135 = nameof(ParallelSquareM135);
        public static string ParallelSquareM0 = nameof(ParallelSquareM0);
        public static string ParallelSquareM45 = nameof(ParallelSquareM45);
    }
}
