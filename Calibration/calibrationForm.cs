using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calibration
{
    public partial class calibrationForm : Form
    {
        public static Tuple<IntPtr, IntPtr> calConnection;
        private System.Threading.Timer timer1;
        public calibrationForm(Tuple<IntPtr, IntPtr> connection)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            calConnection = connection;

            CalibrateToolStrip.Location = new Point(this.Width / 2 - CalibrateToolStrip.Width / 2, 30);

        }

        private void onePointCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_1), null, 250, 25);
            CalibrateToolStrip.Hide();
        }

        private void twoPointsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_2), null, 250, 25);
            CalibrateToolStrip.Hide();
        }

        private void threePointsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_3), null, 250, 25);
            CalibrateToolStrip.Hide();
        }

        private void fourPointsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_4), null, 250, 25);
            CalibrateToolStrip.Hide();
        }

        private void fivePointsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_5), null, 250, 25);
            CalibrateToolStrip.Hide();
        }

        private void sixPointsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_6), null, 250, 25);
            CalibrateToolStrip.Hide();
        }

        private void sevenPointsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_7), null, 250, 25);
            CalibrateToolStrip.Hide();
        }

        private void eightPointsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_8), null, 250, 25);
            CalibrateToolStrip.Hide();
        }

        private void ninePointsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);
            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_9), null, 250, 25);
            CalibrateToolStrip.Hide();
        }






        private void Calibrate_1(object msg)
        {
            var x1 = 0.5;
            var y1 = 0.5;
            if (pictBoxCal1.Width > 15)
            {
                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    pictBoxCal1.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }

        private void Calibrate_2(object msg)
        {
            var x1 = 0.25;
            var y1 = 0.5;
            var x2 = 0.75;
            var y2 = 0.5;

            if (pictBoxCal1.Width > 15)
            {
                
                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    changeNewPictBox(pictBoxCal1, pictBoxCal2, x2, y2);
                }
            }

            else if (pictBoxCal2.Width > 15)
            {
                
                updatePictBox(pictBoxCal2, x2, y2);

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x2, y2);
                    pictBoxCal2.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }

        private void Calibrate_3(object msg)
        {
            var x1 = 0.25;
            var y1 = 0.75;
            var x2 = 0.5;
            var y2 = 0.25;
            var x3 = 0.75;
            var y3 = 0.75;

            if (pictBoxCal1.Width > 15)
            {

                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    changeNewPictBox(pictBoxCal1, pictBoxCal2, x2, y2);
                }
            }

            else if (pictBoxCal2.Width > 15)
            {

                updatePictBox(pictBoxCal2, x2, y2);

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x2, y2);
                    changeNewPictBox(pictBoxCal2, pictBoxCal3, x3, y3);
                }
            }

            else if (pictBoxCal3.Width > 15)
            {

                updatePictBox(pictBoxCal3, x3, y3);

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x3, y3);
                    pictBoxCal3.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }

        private void Calibrate_4(object msg)
        {
            var x1 = 0.05;
            var y1 = 0.05;
            var x2 = 0.95;
            var y2 = 0.05;
            var x3 = 0.95;
            var y3 = 0.95;
            var x4 = 0.05;
            var y4 = 0.95;

            if (pictBoxCal1.Width > 15)
            {

                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    changeNewPictBox(pictBoxCal1, pictBoxCal2, x2, y2);
                }
            }

            else if (pictBoxCal2.Width > 15)
            {

                updatePictBox(pictBoxCal2, x2, y2);

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x2, y2);
                    changeNewPictBox(pictBoxCal2, pictBoxCal3, x3, y3);
                }
            }

            else if (pictBoxCal3.Width > 15)
            {

                updatePictBox(pictBoxCal3, x3, y3);

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x3, y3);
                    changeNewPictBox(pictBoxCal3, pictBoxCal4, x4, y4);
                }
            }

            else if (pictBoxCal4.Width > 15)
            {

                updatePictBox(pictBoxCal4, x4, y4);

                if (pictBoxCal4.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x4, y4);
                    pictBoxCal4.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }

        private void Calibrate_5(object msg)
        {
            var x1 = 0.05;
            var y1 = 0.05;
            var x2 = 0.95;
            var y2 = 0.05;
            var x3 = 0.95;
            var y3 = 0.95;
            var x4 = 0.05;
            var y4 = 0.95;
            var x5 = 0.5;
            var y5 = 0.5;

            if (pictBoxCal1.Width > 15)
            {

                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    changeNewPictBox(pictBoxCal1, pictBoxCal2, x2, y2);
                }
            }

            else if (pictBoxCal2.Width > 15)
            {

                updatePictBox(pictBoxCal2, x2, y2);

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x2, y2);
                    changeNewPictBox(pictBoxCal2, pictBoxCal3, x3, y3);
                }
            }

            else if (pictBoxCal3.Width > 15)
            {

                updatePictBox(pictBoxCal3, x3, y3);

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x3, y3);
                    changeNewPictBox(pictBoxCal3, pictBoxCal4, x4, y4);
                }
            }

            else if (pictBoxCal4.Width > 15)
            {

                updatePictBox(pictBoxCal4, x4, y4);

                if (pictBoxCal4.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x4, y4);
                    changeNewPictBox(pictBoxCal4, pictBoxCal5, x5, y5);
                }
            }

            else if (pictBoxCal5.Width > 15)
            {

                updatePictBox(pictBoxCal5, x5, y5);

                if (pictBoxCal5.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x5, y5);
                    pictBoxCal5.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }

        private void Calibrate_6(object msg)
        {
            var x1 = 0.05;
            var y1 = 0.05;
            var x2 = 0.95;
            var y2 = 0.05;
            var x3 = 0.95;
            var y3 = 0.95;
            var x4 = 0.05;
            var y4 = 0.95;
            var x5 = 0.25;
            var y5 = 0.5;
            var x6 = 0.75;
            var y6 = 0.5;

            if (pictBoxCal1.Width > 15)
            {

                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    changeNewPictBox(pictBoxCal1, pictBoxCal2, x2, y2);
                }
            }

            else if (pictBoxCal2.Width > 15)
            {

                updatePictBox(pictBoxCal2, x2, y2);

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x2, y2);
                    changeNewPictBox(pictBoxCal2, pictBoxCal3, x3, y3);
                }
            }

            else if (pictBoxCal3.Width > 15)
            {

                updatePictBox(pictBoxCal3, x3, y3);

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x3, y3);
                    changeNewPictBox(pictBoxCal3, pictBoxCal4, x4, y4);
                }
            }

            else if (pictBoxCal4.Width > 15)
            {

                updatePictBox(pictBoxCal4, x4, y4);

                if (pictBoxCal4.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x4, y4);
                    changeNewPictBox(pictBoxCal4, pictBoxCal5, x5, y5);
                }
            }

            else if (pictBoxCal5.Width > 15)
            {

                updatePictBox(pictBoxCal5, x5, y5);

                if (pictBoxCal5.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x5, y5);
                    changeNewPictBox(pictBoxCal5, pictBoxCal6, x6, y6);
                }
            }

            else if (pictBoxCal6.Width > 15)
            {

                updatePictBox(pictBoxCal6, x6, y6);

                if (pictBoxCal6.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x6, y6);
                    pictBoxCal6.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }

        private void Calibrate_7(object msg)
        {
            var x1 = 0.05;
            var y1 = 0.05;
            var x2 = 0.95;
            var y2 = 0.05;
            var x3 = 0.95;
            var y3 = 0.95;
            var x4 = 0.05;
            var y4 = 0.95;
            var x5 = 0.25;
            var y5 = 0.75;
            var x6 = 0.5;
            var y6 = 0.25;
            var x7 = 0.75;
            var y7 = 0.75;

            if (pictBoxCal1.Width > 15)
            {

                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    changeNewPictBox(pictBoxCal1, pictBoxCal2, x2, y2);
                }
            }

            else if (pictBoxCal2.Width > 15)
            {

                updatePictBox(pictBoxCal2, x2, y2);

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x2, y2);
                    changeNewPictBox(pictBoxCal2, pictBoxCal3, x3, y3);
                }
            }

            else if (pictBoxCal3.Width > 15)
            {

                updatePictBox(pictBoxCal3, x3, y3);

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x3, y3);
                    changeNewPictBox(pictBoxCal3, pictBoxCal4, x4, y4);
                }
            }

            else if (pictBoxCal4.Width > 15)
            {

                updatePictBox(pictBoxCal4, x4, y4);

                if (pictBoxCal4.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x4, y4);
                    changeNewPictBox(pictBoxCal4, pictBoxCal5, x5, y5);
                }
            }

            else if (pictBoxCal5.Width > 15)
            {

                updatePictBox(pictBoxCal5, x5, y5);

                if (pictBoxCal5.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x5, y5);
                    changeNewPictBox(pictBoxCal5, pictBoxCal6, x6, y6);
                }
            }

            else if (pictBoxCal6.Width > 15)
            {

                updatePictBox(pictBoxCal6, x6, y6);

                if (pictBoxCal6.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x6, y6);
                    changeNewPictBox(pictBoxCal6, pictBoxCal7, x7, y7);
                }
            }

            else if (pictBoxCal7.Width > 15)
            {

                updatePictBox(pictBoxCal7, x7, y7);

                if (pictBoxCal7.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x7, y7);
                    pictBoxCal7.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }

        private void Calibrate_8(object msg)
        {
            var x1 = 0.05;
            var y1 = 0.05;
            var x2 = 0.95;
            var y2 = 0.05;
            var x3 = 0.95;
            var y3 = 0.95;
            var x4 = 0.05;
            var y4 = 0.95;
            var x5 = 0.25;
            var y5 = 0.5;
            var x6 = 0.5;
            var y6 = 0.25;
            var x7 = 0.75;
            var y7 = 0.5;
            var x8 = 0.5;
            var y8 = 0.75;

            if (pictBoxCal1.Width > 15)
            {

                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    changeNewPictBox(pictBoxCal1, pictBoxCal2, x2, y2);
                }
            }

            else if (pictBoxCal2.Width > 15)
            {

                updatePictBox(pictBoxCal2, x2, y2);

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x2, y2);
                    changeNewPictBox(pictBoxCal2, pictBoxCal3, x3, y3);
                }
            }

            else if (pictBoxCal3.Width > 15)
            {

                updatePictBox(pictBoxCal3, x3, y3);

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x3, y3);
                    changeNewPictBox(pictBoxCal3, pictBoxCal4, x4, y4);
                }
            }

            else if (pictBoxCal4.Width > 15)
            {

                updatePictBox(pictBoxCal4, x4, y4);

                if (pictBoxCal4.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x4, y4);
                    changeNewPictBox(pictBoxCal4, pictBoxCal5, x5, y5);
                }
            }

            else if (pictBoxCal5.Width > 15)
            {

                updatePictBox(pictBoxCal5, x5, y5);

                if (pictBoxCal5.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x5, y5);
                    changeNewPictBox(pictBoxCal5, pictBoxCal6, x6, y6);
                }
            }

            else if (pictBoxCal6.Width > 15)
            {

                updatePictBox(pictBoxCal6, x6, y6);

                if (pictBoxCal6.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x6, y6);
                    changeNewPictBox(pictBoxCal6, pictBoxCal7, x7, y7);
                }
            }

            else if (pictBoxCal7.Width > 15)
            {

                updatePictBox(pictBoxCal7, x7, y7);

                if (pictBoxCal7.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x7, y7);
                    changeNewPictBox(pictBoxCal7, pictBoxCal8, x8, y8);
                }
            }

            else if (pictBoxCal8.Width > 15)
            {

                updatePictBox(pictBoxCal8, x8, y8);

                if (pictBoxCal8.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x8, y8);
                    pictBoxCal8.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }

        private void Calibrate_9(object msg)
        {
            var x1 = 0.05;
            var y1 = 0.05;
            var x2 = 0.95;
            var y2 = 0.05;
            var x3 = 0.95;
            var y3 = 0.95;
            var x4 = 0.05;
            var y4 = 0.95;
            var x5 = 0.25;
            var y5 = 0.5;
            var x6 = 0.5;
            var y6 = 0.25;
            var x7 = 0.75;
            var y7 = 0.5;
            var x8 = 0.5;
            var y8 = 0.75;
            var x9 = 0.5;
            var y9 = 0.5;

            if (pictBoxCal1.Width > 15)
            {

                updatePictBox(pictBoxCal1, x1, y1);

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x1, y1);
                    changeNewPictBox(pictBoxCal1, pictBoxCal2, x2, y2);
                }
            }

            else if (pictBoxCal2.Width > 15)
            {

                updatePictBox(pictBoxCal2, x2, y2);

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x2, y2);
                    changeNewPictBox(pictBoxCal2, pictBoxCal3, x3, y3);
                }
            }

            else if (pictBoxCal3.Width > 15)
            {

                updatePictBox(pictBoxCal3, x3, y3);

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x3, y3);
                    changeNewPictBox(pictBoxCal3, pictBoxCal4, x4, y4);
                }
            }

            else if (pictBoxCal4.Width > 15)
            {

                updatePictBox(pictBoxCal4, x4, y4);

                if (pictBoxCal4.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x4, y4);
                    changeNewPictBox(pictBoxCal4, pictBoxCal5, x5, y5);
                }
            }

            else if (pictBoxCal5.Width > 15)
            {

                updatePictBox(pictBoxCal5, x5, y5);

                if (pictBoxCal5.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x5, y5);
                    changeNewPictBox(pictBoxCal5, pictBoxCal6, x6, y6);
                }
            }

            else if (pictBoxCal6.Width > 15)
            {

                updatePictBox(pictBoxCal6, x6, y6);

                if (pictBoxCal6.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x6, y6);
                    changeNewPictBox(pictBoxCal6, pictBoxCal7, x7, y7);
                }
            }

            else if (pictBoxCal7.Width > 15)
            {

                updatePictBox(pictBoxCal7, x7, y7);

                if (pictBoxCal7.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x7, y7);
                    changeNewPictBox(pictBoxCal7, pictBoxCal8, x8, y8);
                }
            }

            else if (pictBoxCal8.Width > 15)
            {

                updatePictBox(pictBoxCal8, x8, y8);

                if (pictBoxCal8.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x8, y8);
                    changeNewPictBox(pictBoxCal8, pictBoxCal9, x9, y9);
                }
            }

            else if (pictBoxCal9.Width > 15)
            {

                updatePictBox(pictBoxCal9, x9, y9);

                if (pictBoxCal9.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, x9, y9);
                    pictBoxCal9.BackColor = Color.Green;
                }
            }
            else
            {
                computeAndClose();
            }
        }


        private void updatePictBox(PictureBox box, double x, double y)
        {
            float formHeight = this.Height;
            float formWidth = this.Width;
            box.Invoke(new MethodInvoker(delegate
            {
                box.Width--;
                box.Height--;
                box.Location = new Point((int)(formWidth * x - box.Width / 2), ((int)(formHeight * y - box.Height / 2)));
                box.BackColor = Color.Red;
            }));
        }

        private void changeNewPictBox(PictureBox oldBox, PictureBox newBox, double x, double y)
        {
            float formHeight = this.Height;
            float formWidth = this.Width;
            newBox.Invoke(new MethodInvoker(delegate
            {
                oldBox.BackColor = Color.Green;
                newBox.Location = new Point((int)(formWidth * x - newBox.Width / 2), ((int)(formHeight * y - newBox.Height / 2)));
                newBox.BackColor = Color.Red;
            }));
        }

        private void computeAndClose()
        {
            timer1.Change(Timeout.Infinite, Timeout.Infinite);
            TobiiTracker.computeApplyStopPersonCal(calConnection.Item1);
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }        
    }
}
