using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Tobii.StreamEngine;
using System.Threading;

namespace EyetrackerButton
{
    public partial class Form1 : Form
    {
        public TobiiTracker tobiiTracker = new TobiiTracker();
        public Thread thread;
        public Tuple<IntPtr, IntPtr> connection;

        // button state variableen
        public bool btnActiveState = false;

        public long beginTime = 0;
        public long activeTime = 0;


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            thread = new Thread(new ThreadStart(recording));


            
        }

        public void btnRecord_Click(object sender, EventArgs e)
        {

            thread.Start();
            
            
        }

        public void recording()
        {

            // rooie vierkant
            MovingAverage xAverageGaze = new MovingAverage(10);
            MovingAverage yAverageGaze = new MovingAverage(10);

            float xGaze;
            float yGaze;

            // blauwe vierkant
            MovingAverage xAverage = new MovingAverage(150);
            MovingAverage yAverage = new MovingAverage(150);

            float xMovingAverage;
            float yMovingAverage;

            while (true)
            {
                TobiiTracker.record(connection.Item1);
                //Console.WriteLine($"Gaze point: {TobiiTracker.coordinaat_x}, {TobiiTracker.coordinaat_y}");

                // rooie vierkant
                xGaze = xAverageGaze.Next(TobiiTracker.coordinaat_x);
                yGaze = yAverageGaze.Next(TobiiTracker.coordinaat_y);

                // blauwe vierkant
                xMovingAverage = xAverage.Next(TobiiTracker.coordinaat_x);
                yMovingAverage = yAverage.Next(TobiiTracker.coordinaat_y);

                // update x-coor label
                if (lblX_Val.InvokeRequired)
                    lblX_Val.Invoke(new MethodInvoker(delegate { lblX_Val.Text = TobiiTracker.coordinaat_x.ToString("0.0000000"); }));
                else
                    lblX_Val.Text = "ERROR";

                // update y-coor label
                if (lblY_val.InvokeRequired)
                    lblY_val.Invoke(new MethodInvoker(delegate { lblY_val.Text = TobiiTracker.coordinaat_y.ToString("0.0000000"); }));
                else
                    lblY_val.Text = "ERROR";

                // update x-coor avg label
                if (lblXAvg.InvokeRequired)
                    lblXAvg.Invoke(new MethodInvoker(delegate { lblXAvg.Text = xMovingAverage.ToString("0.0000000"); }));
                else
                    lblXAvg.Text = "ERROR";

                // update y-coor avg label
                if (lblYAvg.InvokeRequired)
                    lblYAvg.Invoke(new MethodInvoker(delegate { lblYAvg.Text = yMovingAverage.ToString("0.0000000"); }));
                else
                    lblYAvg.Text = "ERROR";

                // update time label
                if (lblTime_val.InvokeRequired)
                    lblTime_val.Invoke(new MethodInvoker(delegate { lblTime_val.Text = TobiiTracker.timestamp.ToString(); }));
                else
                    lblTime_val.Text = "ERROR";

                float formHeight = this.Height;
                float formWidth = this.Width;

                gazeBox.Invoke(new MethodInvoker(delegate { gazeBox.Location = new Point((int)(formWidth * xGaze), ((int)(formHeight * yGaze))); }));
                gazeBoxAvg.Invoke(new MethodInvoker(delegate { gazeBoxAvg.Location = new Point((int)(formWidth * xMovingAverage), ((int)(formHeight * yMovingAverage))); }));

                bool btnActive;
                btnActive = checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp);


            }
        }

        public bool checkIfBtnActive(float xGaze, float yGaze, float xMovingAverage, float yMovingAverage, long timestamp)
        {
            int btnSizeX_left = (int)(this.Width * 0.75);
            int btnSizeY_top = (int)(this.Height * 0.75);
            int btnSizeX_right = (int)((this.Width * 0.75) +  150);
            int btnSizeY_bottem = (int)((this.Height * 0.75) + 150);

            int xGazePixel = (int)(this.Width * xGaze);
            int yGazePixel = (int)(this.Height * yGaze);

            int xMovingAvgPixel = (int)(this.Width * xMovingAverage);
            int yMovingAvgPixel = (int)(this.Height * yMovingAverage);



            if (btnSizeX_left < xGazePixel && xGazePixel < btnSizeX_right && btnSizeY_top < yGazePixel && yGazePixel < btnSizeY_bottem)
            {
                if (btnActiveState ==  true)
                {
                    activeTime = timestamp - beginTime;
                    Console.WriteLine(activeTime/1000000);
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
            } else if(btnSizeX_left < xMovingAvgPixel && xMovingAvgPixel < btnSizeX_right && btnSizeY_top < yMovingAvgPixel && yMovingAvgPixel < btnSizeY_bottem)
            {
                btnActiveState = true;
                Console.WriteLine("blauw er nog in");
            } else
            {
                lookBtn.BackColor = Color.Yellow;
                btnActiveState = false;
            }



            return true;
        }

        public void btnDisconnect_Click(object sender, EventArgs e)
        {
            thread.Abort();
            TobiiTracker.unsubscribe(connection.Item1, connection.Item2);
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            // connection.Item1 =  deviceContext & connection.Item2 = apiContext

            float formHeight = this.Height;
            float formWidth = this.Width;
            var a = 0.025;
            var b = 0.975;
            testbox1.Location = new Point((int)(formWidth * 0.5), ((int)(formHeight * 0.5)));
            testbox2.Location = new Point((int)(formWidth * a), ((int)(formHeight * a)));
            testbox3.Location = new Point((int)(formWidth * a), ((int)(formHeight * b)));
            testbox4.Location = new Point((int)(formWidth * b), ((int)(formHeight * b)));
            testbox5.Location = new Point((int)(formWidth * b), ((int)(formHeight * a)));
            connection = TobiiTracker.subscribe();

            lookBtn.Location = new Point((int)(formWidth * 0.75), ((int)(formHeight * 0.75)));
            lookBtn.SendToBack();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(connection);
            f2.ShowDialog(); // Shows Form2
        }

        private void btnGetTime_Click(object sender, EventArgs e)
        {
            lblGetTime.Text = TobiiTracker.timestamp.ToString();
        }
    }
}
