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

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game.Start();
            btnStart.Enabled = false;
            lblLevel.Text = Game.Level.ToString();
            BtnSetVisible();
        }
        
        private void btnPreviousLevel_Click(object sender, EventArgs e)
        {
            Game.PreviousLevel();
            lblLevel.Text = Game.Level.ToString();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            Game.NextLevel();
            lblLevel.Text = Game.Level.ToString();
        }
        public void BtnNextLevelEnable(bool enable=false)
        {
            btnNextLevel.Enabled = enable;
        }
        public void BtnPreviousLevelEnable(bool enable = false)
        {
            btnPreviousLevel.Enabled = enable;
        }
        public void BtnSetVisible()
        {
            btnNextLevel.Visible = true;
            btnPreviousLevel.Visible = true;
            btnPreviousLevel.Enabled = false;
            lblLevel.Visible = true;
            label1.Visible = true;
            btnStart.Enabled = false;
        }
    }
}

