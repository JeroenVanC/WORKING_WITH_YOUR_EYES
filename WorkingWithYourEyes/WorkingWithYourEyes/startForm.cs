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


namespace WorkingWithYourEyes
{
    public partial class startForm : Form
    {
        public TobiiTracker tobiiTracker = new TobiiTracker();
        public Thread thread;
        public Tuple<IntPtr, IntPtr> connection;

        // button state variableen
        public bool btnActiveState = false;

        public long beginTime = 0;
        public long activeTime = 0;
        public startForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            thread.Abort();
            TobiiTracker.unsubscribe(connection.Item1, connection.Item2);
        }

        private void btnCalibr_Click(object sender, EventArgs e)
        {
            calibrationForm calibrationForm = new calibrationForm(connection);
            calibrationForm.ShowDialog(); // Shows Form2
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            thread.Start();
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            // connection.Item1 =  deviceContext & connection.Item2 = apiContext
            thread = new Thread(new ThreadStart(recording));
            connection = TobiiTracker.subscribe();
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
                if (lblXCoData.InvokeRequired)
                    lblXCoData.Invoke(new MethodInvoker(delegate { lblXCoData.Text = TobiiTracker.coordinaat_x.ToString("0.0000000"); }));
                else
                    lblXCoData.Text = "ERROR";

                // update y-coor label
                if (lblYCoData.InvokeRequired)
                    lblYCoData.Invoke(new MethodInvoker(delegate { lblYCoData.Text = TobiiTracker.coordinaat_y.ToString("0.0000000"); }));
                else
                    lblYCoData.Text = "ERROR";



                float formHeight = this.Height;
                float formWidth = this.Width;

                gazeBox.Invoke(new MethodInvoker(delegate { gazeBox.Location = new Point((int)(formWidth * TobiiTracker.coordinaat_x - gazeBox.Width / 2), ((int)(formHeight * TobiiTracker.coordinaat_y - gazeBox.Height / 2))); }));
                //gazeBoxAvg.Invoke(new MethodInvoker(delegate { gazeBoxAvg.Location = new Point((int)(formWidth * xMovingAverage), ((int)(formHeight * yMovingAverage))); }));

                //bool btnActive;
                //btnActive = checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp);


            }
        }

        private void startForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }
    }
}