using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instructionForm
{
    public partial class DemoForm : Form
    {

        public static Tuple<IntPtr, IntPtr> demoConnection;

        //btn state
        public bool btnActiveState = false;
        public long beginTime = 0;
        public long activeTime = 0;

        // rooie vierkant
        public MovingAverage xAverageGaze = new MovingAverage(10);
        public MovingAverage yAverageGaze = new MovingAverage(10);

        public float xGaze;
        public float yGaze;

        // blauwe vierkant
        public MovingAverage xAverage = new MovingAverage(150);
        public MovingAverage yAverage = new MovingAverage(150);

        public float xMovingAverage;
        public float yMovingAverage;

        private System.Threading.Timer timer1;
        public DemoForm(Tuple<IntPtr, IntPtr> connection)
        {
            InitializeComponent();
            demoConnection = connection;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            gazeBox.BringToFront();

            //thread.Start();
            timer1 = new System.Threading.Timer(new TimerCallback(recording), null, 250, 5);

            this.KeyPreview = true;
        }


        public void recording(object msg)
        {


            //while (true)
            //{
            TobiiTracker.record(demoConnection.Item1);
            //Console.WriteLine($"Gaze point: {TobiiTracker.coordinaat_x}, {TobiiTracker.coordinaat_y}");

            // rooie vierkant
            xGaze = xAverageGaze.Next(TobiiTracker.coordinaat_x);
            yGaze = yAverageGaze.Next(TobiiTracker.coordinaat_y);

            // blauwe vierkant
            xMovingAverage = xAverage.Next(TobiiTracker.coordinaat_x);
            yMovingAverage = yAverage.Next(TobiiTracker.coordinaat_y);

            // update x-coor label
            //if (lblXCoData.InvokeRequired)
            //    lblXCoData.Invoke(new MethodInvoker(delegate { lblXCoData.Text = TobiiTracker.coordinaat_x.ToString("0.0000000"); }));
            //else
            //    lblXCoData.Text = "ERROR";

            //// update y-coor label
            //if (lblYCoData.InvokeRequired)
            //    lblYCoData.Invoke(new MethodInvoker(delegate { lblYCoData.Text = TobiiTracker.coordinaat_y.ToString("0.0000000"); }));
            //else
            //    lblYCoData.Text = "ERROR";



            float formHeight = this.Height;
            float formWidth = this.Width;

            gazeBox.Invoke(new MethodInvoker(delegate { gazeBox.Location = new Point((int)(formWidth * TobiiTracker.coordinaat_x - gazeBox.Width / 2), ((int)(formHeight * TobiiTracker.coordinaat_y - gazeBox.Height / 2))); }));
            //gazeBoxAvg.Invoke(new MethodInvoker(delegate { gazeBoxAvg.Location = new Point((int)(formWidth * xMovingAverage), ((int)(formHeight * yMovingAverage))); }));

            bool btnActive;
            btnActive = checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp);


            //}


        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }

        private void DemoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;

                timer1.Change(Timeout.Infinite, Timeout.Infinite);
            }
        }

        private void lblTitle2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        public bool checkIfBtnActive(float xGaze, float yGaze, float xMovingAverage, float yMovingAverage, long timestamp)
        {

            int btnSizeX_left = (int)lookBtn.Location.X;//(this.Width * 0.75);
            int btnSizeY_top = (int)lookBtn.Location.Y;//(this.Height * 0.75);
            int btnSizeX_right = (int)lookBtn.Location.X + lookBtn.Width;//((this.Width * 0.75) + 150);
            int btnSizeY_bottem = (int)lookBtn.Location.Y + lookBtn.Height;

            int xGazePixel = (int)(this.Width * xGaze);
            int yGazePixel = (int)(this.Height * yGaze);

            int xMovingAvgPixel = (int)(this.Width * xMovingAverage);
            int yMovingAvgPixel = (int)(this.Height * yMovingAverage);



            if (btnSizeX_left < xGazePixel && xGazePixel < btnSizeX_right && btnSizeY_top < yGazePixel && yGazePixel < btnSizeY_bottem)
            {
                if (btnActiveState == true)
                {
                    activeTime = timestamp - beginTime;
                    Console.WriteLine(activeTime / 1000000);
                    if (activeTime > 5000000)
                    {
                        lookBtn.BackColor = Color.Green;
                    }
                }
                else
                {
                    beginTime = timestamp;
                    btnActiveState = true;
                }
            }
            else if (btnSizeX_left < xMovingAvgPixel && xMovingAvgPixel < btnSizeX_right && btnSizeY_top < yMovingAvgPixel && yMovingAvgPixel < btnSizeY_bottem)
            {
                btnActiveState = true;
                Console.WriteLine("blauw er nog in");
            }
            else
            {
                lookBtn.BackColor = Color.Yellow;
                btnActiveState = false;
            }

            return true;
        }
    }
}
