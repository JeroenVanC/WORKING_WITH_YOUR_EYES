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

    
    public partial class startForm : Form
    {

        public TobiiTracker tobiiTracker = new TobiiTracker();
        public Thread thread;
        public Tuple<IntPtr, IntPtr> connection;

        // button state variableen
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

        public startForm()
        {
            InitializeComponent();

            

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            lblTitle1.Location = new Point(this.Width / 2 - lblTitle1.Width / 2, 30);
            lblTitle2.Location = new Point(this.Width / 2 - lblTitle2.Width / 2, 80);
            btnConnect.Location = new Point(this.Width / 2 - btnConnect.Width / 2, 150);


            btnCalibr.Hide();
            btnRecord.Hide();
            btnDiscon.Hide();

            this.KeyPreview = true;
            gazeBox.BackColor = Color.Transparent;
            gazeBox.BringToFront();

           
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            DemoForm demoFrom = new DemoForm(connection);
            demoFrom.ShowDialog();

            ////thread.Start();
            //timer1 = new System.Threading.Timer(new TimerCallback(recording), null, 250, 5);

        }


        private void btnCalibr_Click(object sender, EventArgs e)
        {
            
            calibrationForm calibrationForm = new calibrationForm(connection);
            calibrationForm.ShowDialog(); // Shows Form2

            //layout
            btnRecord.Show();
            btnDiscon.Location = new Point(this.Width / 2 - btnDiscon.Width / 2, 310);
            btnRecord.Location = new Point(this.Width / 2 - btnRecord.Width / 2, 230);
            lblTitle2.Text = "You can now start the demo.";
            lblTitle2.Location = new Point(this.Width / 2 - lblTitle2.Width / 2, 80);

        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            // connection.Item1 =  deviceContext & connection.Item2 = apiContext
            //thread = new Thread(new ThreadStart(recording));
            connection = TobiiTracker.subscribe();

            //layout
            btnConnect.Hide();
            btnCalibr.Show();
            btnDiscon.Show();
            btnCalibr.Location = new Point(this.Width / 2 - btnCalibr.Width / 2, 150);
            btnDiscon.Location = new Point(this.Width / 2 - btnDiscon.Width / 2, 230);
            lblTitle2.Text = "Press the calibration button to improve your eye tracking.";

        }

        //public void recording(object msg)
        //{
            

        //    //while (true)
        //    //{
        //        TobiiTracker.record(connection.Item1);
        //        //Console.WriteLine($"Gaze point: {TobiiTracker.coordinaat_x}, {TobiiTracker.coordinaat_y}");

        //        // rooie vierkant
        //        xGaze = xAverageGaze.Next(TobiiTracker.coordinaat_x);
        //        yGaze = yAverageGaze.Next(TobiiTracker.coordinaat_y);

        //        // blauwe vierkant
        //        xMovingAverage = xAverage.Next(TobiiTracker.coordinaat_x);
        //        yMovingAverage = yAverage.Next(TobiiTracker.coordinaat_y);

        //        // update x-coor label
        //        //if (lblXCoData.InvokeRequired)
        //        //    lblXCoData.Invoke(new MethodInvoker(delegate { lblXCoData.Text = TobiiTracker.coordinaat_x.ToString("0.0000000"); }));
        //        //else
        //        //    lblXCoData.Text = "ERROR";

        //        //// update y-coor label
        //        //if (lblYCoData.InvokeRequired)
        //        //    lblYCoData.Invoke(new MethodInvoker(delegate { lblYCoData.Text = TobiiTracker.coordinaat_y.ToString("0.0000000"); }));
        //        //else
        //        //    lblYCoData.Text = "ERROR";

                

        //        float formHeight = this.Height;
        //        float formWidth = this.Width;

        //        gazeBox.Invoke(new MethodInvoker(delegate { gazeBox.Location = new Point((int)(formWidth * TobiiTracker.coordinaat_x - gazeBox.Width / 2), ((int)(formHeight * TobiiTracker.coordinaat_y - gazeBox.Height / 2))); }));
        //        //gazeBoxAvg.Invoke(new MethodInvoker(delegate { gazeBoxAvg.Location = new Point((int)(formWidth * xMovingAverage), ((int)(formHeight * yMovingAverage))); }));

        //        //bool btnActive;
        //        //btnActive = checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp);


        //    //}
        //}

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            //thread.Abort();
            timer1.Change(Timeout.Infinite, Timeout.Infinite);
            TobiiTracker.unsubscribe(connection.Item1, connection.Item2);
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

        private void startForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
