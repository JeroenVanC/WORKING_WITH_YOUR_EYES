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

            btnStartCal1.Location = new Point(this.Width / 2 - btnStartCal1.Width / 2, 30);
            calConnection = connection;
        }

        private void btnStartCal1_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);

            float formHeight = this.Height;
            float formWidth = this.Width;

            pictBoxCal1.Location = new Point((int)(formWidth * 0.5 - pictBoxCal1.Width / 2), ((int)(formHeight * 0.5 - pictBoxCal1.Height / 2)));
            pictBoxCal1.BackColor = Color.Red;

            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate_1), null, 250, 25);
        }

        private void Calibrate_1(object msg)
        {

            float formHeight = this.Height;
            float formWidth = this.Width;

            if (pictBoxCal1.Width > 15)
            {
                pictBoxCal1.Invoke(new MethodInvoker(delegate
                {
                    pictBoxCal1.Width--;
                    pictBoxCal1.Height--;
                    pictBoxCal1.Location = new Point((int)(formWidth * 0.5 - pictBoxCal1.Width / 2), ((int)(formHeight * 0.5 - pictBoxCal1.Height / 2)));
                }));

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.5, 0.5);
                    pictBoxCal1.BackColor = Color.Green;
                }
            }
            
            else
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
}
