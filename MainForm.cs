using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DarkParachute
{
    public partial class MainForm : Form
    {
        private Utils utils;

        public MainForm()
        {
            InitializeComponent();

            utils = new Utils();
        }

        private void radiusBox_ValueChanged(object sender, EventArgs e)
        {
            renderPanel.Refresh();
        }

        private void goresBox_ValueChanged(object sender, EventArgs e)
        {
            renderPanel.Refresh();
        }

        private void ratioBox_ValueChanged(object sender, EventArgs e)
        {
            renderPanel.Refresh();
        }

        private void holeBox_ValueChanged(object sender, EventArgs e)
        {
            renderPanel.Refresh();
        }

        private void sphereBox_ValueChanged(object sender, EventArgs e)
        {
            renderPanel.Refresh();
        }

        private void marginBox_ValueChanged(object sender, EventArgs e)
        {
            renderPanel.Refresh();
        }

        private void renderPanel_Paint(object sender, PaintEventArgs e)
        {
            utils.makeParachute(e,
                renderPanel,
                Convert.ToInt32(radiusBox.Value), 
                Convert.ToInt32(goresBox.Value), 
                (float)ratioBox.Value, 
                Convert.ToInt32(holeBox.Value), 
                Convert.ToInt32(sphereBox.Value),
                Convert.ToInt32(marginBox.Value));
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            int width = renderPanel.Size.Width;
            int height = renderPanel.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            renderPanel.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

            bm.Save("ParachutePatternGore.bmp", ImageFormat.Bmp);
        }

        private void cylinderRadiusBox_ValueChanged(object sender, EventArgs e)
        {
            cylinderRenderPanel.Refresh();
        }

        private void holesBox_ValueChanged(object sender, EventArgs e)
        {
            cylinderRenderPanel.Refresh();
        }

        private void cylinderMarginBox_ValueChanged(object sender, EventArgs e)
        {
            cylinderRenderPanel.Refresh();
        }

        private void holeRadiusBox_ValueChanged(object sender, EventArgs e)
        {
            cylinderRenderPanel.Refresh();
        }

        private void cylinderRenderPanel_Paint(object sender, PaintEventArgs e)
        {
            utils.makeHoles(e,
                            cylinderRenderPanel,
                            Convert.ToInt32(cylinderRadiusBox.Value),
                            Convert.ToInt32(holesBox.Value),
                            Convert.ToInt32(cylinderMarginBox.Value),
                            Convert.ToInt32(holeRadiusBox.Value));
        }

        private void exportCylinderButton_Click(object sender, EventArgs e)
        {
            int width = cylinderRenderPanel.Size.Width;
            int height = cylinderRenderPanel.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            cylinderRenderPanel.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

            bm.Save("CylinderHoles.bmp", ImageFormat.Bmp);
        }

        private void circleRadius_ValueChanged(object sender, EventArgs e)
        {
            circleRenderPanel.Refresh();
        }

        private void circleHoleRadius_ValueChanged(object sender, EventArgs e)
        {
            circleRenderPanel.Refresh();
        }

        private void circleRenderPanel_Paint(object sender, PaintEventArgs e)
        {
            utils.makeCircle(e,
                            circleRenderPanel,
                            Convert.ToInt32(circleRadius.Value),
                            Convert.ToInt32(circleHoleRadius.Value));
        }

        private void exportCircleButton_Click(object sender, EventArgs e)
        {
            int width = circleRenderPanel.Size.Width;
            int height = circleRenderPanel.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            circleRenderPanel.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

            bm.Save("Circle.bmp", ImageFormat.Bmp);
        }
    }
}
