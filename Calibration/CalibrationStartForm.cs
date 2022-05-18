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
    public partial class CalibrationStartForm : Form
    {

        public TobiiTracker tobiiTracker = new TobiiTracker();

        public Tuple<IntPtr, IntPtr> connection;

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

        public CalibrationStartForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.KeyPreview = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connection = TobiiTracker.subscribe();
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            timer1.Change(Timeout.Infinite, Timeout.Infinite);
            TobiiTracker.unsubscribe(connection.Item1, connection.Item2);
        }

        private void CalibrationStartForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void btnCalibr_Click(object sender, EventArgs e)
        {
            calibrationForm calibrationForm = new calibrationForm(connection);
            calibrationForm.ShowDialog();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            timer1 = new System.Threading.Timer(new TimerCallback(recording), null, 250, 5);
        }

        public void recording(object msg)
        {

            TobiiTracker.record(connection.Item1);

            // rooie vierkant
            xGaze = xAverageGaze.Next(TobiiTracker.coordinaat_x);
            yGaze = yAverageGaze.Next(TobiiTracker.coordinaat_y);

            // blauwe vierkant
            xMovingAverage = xAverage.Next(TobiiTracker.coordinaat_x);
            yMovingAverage = yAverage.Next(TobiiTracker.coordinaat_y);

            float formHeight = this.Height;
            float formWidth = this.Width;

            gazeBox.Invoke(new MethodInvoker(delegate { gazeBox.Location = new Point((int)(formWidth * TobiiTracker.coordinaat_x - gazeBox.Width / 2), ((int)(formHeight * TobiiTracker.coordinaat_y - gazeBox.Height / 2))); }));
        }

        private void btnTestCal_Click(object sender, EventArgs e)
        {
            testCalibrationForm testCalibrationForm = new testCalibrationForm();
            testCalibrationForm.ShowDialog();

        }
    }
}
