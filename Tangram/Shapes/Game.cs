using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangram.Shapes.ParallelSquare;
using Tangram.Shapes.Square;
using Tangram.Shapes.Triangles.Big.Big1;
using Tangram.Shapes.Triangles.Big.Big2;
using Tangram.Shapes.Triangles.Middle;
using Tangram.Shapes.Triangles.Small.Small1;
using Tangram.Shapes.Triangles.Small.Small2;
using Point = AForge.Point;

namespace Tangram.Shapes
{
    public static class Game
    {
        private static MainForm mainForm;

        static Game()
        {
            mainForm = (MainForm)Application.OpenForms[0];
        }
        public static LevelPair CurrentLevel
        {
            get
            {
                return Levels[Level];
            }

            private set => Levels[Level] = value;
        }

        public static Dictionary<int, LevelPair> Levels = new Dictionary<int, LevelPair>
        {
            {
                1,
                new LevelPair
                {
                    Level = 1,
                    Size = new Size(Constants.LengthUnit * 6, Constants.LengthUnit * 5),
                    Points = new PointF[]
                    {
                        new PointF(2 * Constants.LengthUnit, 0),
                        new PointF(0, 2 * Constants.LengthUnit),
                        new PointF(Constants.LengthUnit * 6 / 2, 5 * Constants.LengthUnit),
                        new PointF(Constants.LengthUnit * 6, 2 * Constants.LengthUnit),
                        new PointF(Constants.LengthUnit * 4, 0),
                        new PointF(Constants.LengthUnit * 3, Constants.LengthUnit)
                    },
                    Name = "Heart"
                }
            },
            {
                2,
                new LevelPair
                {
                    Level = 2,
                    Size = new Size(Constants.CoefficientUnit*4, Constants.CoefficientUnit*3),
                    Points = new PointF[]
                    {
                        new PointF(0 , Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit, 0),
                        new PointF(Constants.CoefficientUnit*3, 0),
                        new PointF(Constants.CoefficientUnit*4, Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*2, Constants.CoefficientUnit*3),
                        new PointF(Constants.CoefficientUnit*2, Constants.CoefficientUnit*3),
                    },
                    Name = "Diamond"
                }
            },
            {
                3,
                new LevelPair
                {
                    Level = 3,
                    Size = new Size(Constants.CoefficientUnit*4, Constants.CoefficientUnit*2),
                    Points = new PointF[]
                    {
                        new PointF(0,0),
                        new PointF(Constants.CoefficientUnit*4,0),
                        new PointF(Constants.CoefficientUnit*4,Constants.CoefficientUnit*2),
                        new PointF(0,Constants.CoefficientUnit*2)
                    },
                    Name = "Rectangle"
                }
            },
            {
                4,
                new LevelPair
                {
                    Level = 4,
                    Size = new Size(Constants.CoefficientUnit*4, Constants.CoefficientUnit*3),
                    Points = new PointF[]
                    {
                        new PointF(Constants.CoefficientUnit,0),
                        new PointF(Constants.CoefficientUnit*3,0),
                        new PointF(Constants.CoefficientUnit*4,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*4,Constants.CoefficientUnit*2),
                        new PointF(Constants.CoefficientUnit*3,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*3,Constants.CoefficientUnit*3),
                        new PointF(Constants.CoefficientUnit,Constants.CoefficientUnit*3),
                        new PointF(Constants.CoefficientUnit,Constants.CoefficientUnit),
                        new PointF(0,Constants.CoefficientUnit*2),
                        new PointF(0,Constants.CoefficientUnit)
                    },
                    Name = "T-Shirt"
                }
            },
            {
                5,
                new LevelPair
                {
                    Level = 5,
                    Size = new Size(Constants.LengthUnit*4, Constants.LengthUnit*8),
                    Points = new PointF[]
                    {
                        new PointF(Constants.LengthUnit*2,0),
                        new PointF(Constants.LengthUnit*3,Constants.LengthUnit),
                        new PointF(Constants.LengthUnit*3,Constants.LengthUnit*5),
                        new PointF(Constants.LengthUnit*4,Constants.LengthUnit*6),
                        new PointF(Constants.LengthUnit*4,Constants.LengthUnit*8),
                        new PointF(Constants.LengthUnit*2,Constants.LengthUnit*6),
                        new PointF(0,Constants.LengthUnit*8),
                        new PointF(0,Constants.LengthUnit*6),
                        new PointF(Constants.LengthUnit,Constants.LengthUnit*5),
                        new PointF(Constants.LengthUnit,Constants.LengthUnit),
                    },
                    Name = "Roket"
                }
            },
            {
                6,
                new LevelPair
                {
                    Level = 6,
                    Size = new Size(Constants.CoefficientUnit*4, Constants.CoefficientUnit*2+Constants.LengthUnit*2),
                    Points = new PointF[]
                    {
                        new PointF(Constants.LengthUnit*2+(Constants.CoefficientUnit*3-Constants.SquareLength)/2,0),
                        new PointF(Constants.LengthUnit*4+(Constants.CoefficientUnit*3-Constants.SquareLength)/2,Constants.LengthUnit*2),
                        new PointF(Constants.CoefficientUnit*3,Constants.LengthUnit*2),
                        new PointF(Constants.CoefficientUnit*3,Constants.CoefficientUnit+Constants.LengthUnit*2),
                        new PointF(Constants.CoefficientUnit*4,Constants.CoefficientUnit+Constants.LengthUnit*2),
                        new PointF(Constants.CoefficientUnit*4,Constants.CoefficientUnit*2+Constants.LengthUnit*2),
                        new PointF(Constants.CoefficientUnit*2,Constants.CoefficientUnit*2+Constants.LengthUnit*2),
                        new PointF(Constants.CoefficientUnit*2,Constants.CoefficientUnit+Constants.LengthUnit*2),
                        new PointF(Constants.CoefficientUnit,Constants.CoefficientUnit+Constants.LengthUnit*2),
                        new PointF(Constants.CoefficientUnit,Constants.CoefficientUnit*2+Constants.LengthUnit*2),
                        new PointF(0,Constants.CoefficientUnit*2+Constants.LengthUnit*2),
                        new PointF(0,Constants.LengthUnit*2),
                        new PointF((Constants.CoefficientUnit*3-Constants.SquareLength)/2,Constants.LengthUnit*2),
                    },
                    Name = "Home"
                }
            },
            {
                7,
                new LevelPair
                {
                    Level = 7,
                    Size = new Size(Constants.CoefficientUnit*4, Constants.CoefficientUnit*4),
                    Points = new PointF[]
                    {
                        new PointF(0,0),
                        new PointF(Constants.CoefficientUnit*4,0),
                        new PointF(Constants.CoefficientUnit*4,Constants.CoefficientUnit*2),
                        new PointF(Constants.CoefficientUnit*3,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*3- Constants.CoefficientUnit/2,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*3- Constants.CoefficientUnit/2,Constants.CoefficientUnit*4),
                        new PointF(Constants.CoefficientUnit*2- Constants.CoefficientUnit/2,Constants.CoefficientUnit*4),
                        new PointF(Constants.CoefficientUnit*2- Constants.CoefficientUnit/2,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit,Constants.CoefficientUnit),
                        new PointF(0,Constants.CoefficientUnit*2),
                    },
                    Name = "T letter "
                }
            },
            {
                8,
                new LevelPair
                {
                    Level = 8,
                    Size = new Size(Constants.LengthUnit*7,Constants.CoefficientUnit*3+Constants.LengthUnit),
                    Points = new PointF[]
                    {
                        new PointF(0,Constants.CoefficientUnit*3-Constants.LengthUnit),
                        new PointF(Constants.LengthUnit*6,Constants.CoefficientUnit*3-Constants.LengthUnit),
                        new PointF(Constants.LengthUnit*7-Constants.CoefficientUnit*2,Constants.CoefficientUnit),

                        new PointF(Constants.LengthUnit*7-Constants.CoefficientUnit,0),
                        new PointF(Constants.LengthUnit*7,Constants.CoefficientUnit),

                        new PointF(Constants.LengthUnit*7-Constants.CoefficientUnit,Constants.CoefficientUnit),
                        new PointF(Constants.LengthUnit*7,Constants.CoefficientUnit*2),
                        new PointF(Constants.LengthUnit*7,Constants.CoefficientUnit*3),
                        new PointF(Constants.LengthUnit*6,Constants.CoefficientUnit*3+Constants.LengthUnit),
                        new PointF(Constants.LengthUnit*2,Constants.CoefficientUnit*3+Constants.LengthUnit),
                    },
                    Name = "Duck"
                }
            },
            {
                9,
                new LevelPair
                {
                    Level = 9,
                    Size = new Size(Constants.CoefficientUnit*6,Constants.CoefficientUnit*2),
                    Points = new PointF[]
                    {
                        new PointF(0,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*2,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*2,0),
                        new PointF(Constants.CoefficientUnit*5,0),
                        new PointF(Constants.CoefficientUnit*5,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*6,Constants.CoefficientUnit),
                        new PointF(Constants.CoefficientUnit*5,Constants.CoefficientUnit*2),
                        new PointF(Constants.CoefficientUnit,Constants.CoefficientUnit*2),
                    },
                    Name = "Ferryboat"
                }
            }
        };

        public static int Level = 1;

        public static void NextLevel()
        {
            Level++;
            CurrentLevel = Levels[Level];
            ReLocationShapes();
        }
        public static void PreviousLevel()
        {
            Level--;
            CurrentLevel = Levels[Level];
            ReLocationShapes();
        }
        public static void ReLocationShapes()
        {
            mainForm.Controls.Clear();
            mainForm.InitializeComponent();
            mainForm.BtnSetVisible();
            mainForm.BtnPreviousLevelEnable(true);
            mainForm.BtnNextLevelEnable(true);
            Start();
            if (Level == Levels.Count)
            {
                mainForm.BtnNextLevelEnable();
            }
            if (Level == 1)
            {
                mainForm.BtnPreviousLevelEnable();
            }
        }
        public static void Start()
        {
            Big1Triangle135 big1Triangle135 = new Big1Triangle135();
            Big2Triangle45 big2Triangle45 = new Big2Triangle45();
            Small1Triangle225 small1Triangle225 = new Small1Triangle225();
            Small2Triangle315 small1Triangle315 = new Small2Triangle315();
            Square45 square45 = new Square45();
            MiddleTriangle90 middleTriangle90 = new MiddleTriangle90();
            ParallelSquare45 parallelSquare45 = new ParallelSquare45();
            Level level = new Level();

            mainForm.Controls.Add(big1Triangle135);
            mainForm.Controls.Add(big2Triangle45);
            mainForm.Controls.Add(small1Triangle225);
            mainForm.Controls.Add(small1Triangle315);
            mainForm.Controls.Add(square45);
            mainForm.Controls.Add(middleTriangle90);
            mainForm.Controls.Add(parallelSquare45);
            mainForm.Controls.Add(level);
            //level.SendToBack();

            ControlExtension.Draggable(big1Triangle135, true);
            ControlExtension.Draggable(big2Triangle45, true);
            ControlExtension.Draggable(small1Triangle315, true);
            ControlExtension.Draggable(small1Triangle225, true);
            ControlExtension.Draggable(square45, true);
            ControlExtension.Draggable(middleTriangle90, true);
            ControlExtension.Draggable(parallelSquare45, true);
        }
    }
}
