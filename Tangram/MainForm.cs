using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using Tangram.Shapes;
using Tangram.Shapes.ParallelSquare;
using Tangram.Shapes.Square;
using Tangram.Shapes.Triangles.Big.Big1;
using Tangram.Shapes.Triangles.Big.Big2;
using Tangram.Shapes.Triangles.Middle;
using Tangram.Shapes.Triangles.Small.Small1;
using Tangram.Shapes.Triangles.Small.Small2;

namespace Tangram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Game.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }




    }
}

