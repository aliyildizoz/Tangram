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
            lblNameOfShape.Text = Game.CurrentLevel.Name;
            BtnSetVisible();
        }

        private void btnPreviousLevel_Click(object sender, EventArgs e)
        {
            Game.PreviousLevel();
            lblLevel.Text = Game.Level.ToString();
            lblNameOfShape.Text = Game.CurrentLevel.Name;
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            Game.NextLevel();
            lblLevel.Text = Game.Level.ToString();
            lblNameOfShape.Text = Game.CurrentLevel.Name;

        }
        public void BtnNextLevelEnable(bool enable = false)
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
            label2.Visible = true;
            lblNameOfShape.Visible = true;
            btnStart.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Tangram Oyunu Nasıl Oynanır?\r\n\r\nTek kişiliktir. 5 yaş ve üstü herkes için uygun, eğlenceli bir oyundur. Oyunun amacı ise bu parçaları kullanarak farklı formlara ait şekiller oluşturmaktır. Oyunun başında oyuncu için bir form belirlenir ve oyuncu şekilleri kullanarak bu formu oluşturmaya çalışır. Hedefin belirlenmesinde üç aşama vardır. Tangram kolay, orta ve zor seviyeden oluşur.\r\n\r\nBelirlenen hedef bir hayvan, geometrik bir şekil, bir harf ya da yürüyen bir insan vb. olabilir. Oyuncu 7 parçayı da kullanarak belirlenen hedefi oluşturmaya çalışır. Oyun basit bazı kurallara uyarak oynanmalıdır, Tangram oyununun kuralları;\r\n\r\n● Hedef form oluşturulurken 7 parçada kullanılmalıdır.\r\n● Parçalar düz olarak kullanılmalı, dik ya da farklı kullanılamaz.\r\n● Parçalar üst üste konularak hedef oluşturulamaz.\r\n● Hedef oluşturulurken parçalar birbirine temas edecek şekilde yerleştirilmelidir.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeveloppers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ali Yıldızöz", "Geliştiriciler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

