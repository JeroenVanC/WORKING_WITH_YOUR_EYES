using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithYourEyes
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

            btnStartCal.Location = new Point(this.Width / 2 - btnStartCal.Width / 2, 30);

            calConnection = connection;
        }

        private void btnStartCal_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);

            float formHeight = this.Height;
            float formWidth = this.Width;

            pictBoxCal1.Location = new Point((int)(formWidth * 0.5 - pictBoxCal1.Width / 2), ((int)(formHeight * 0.5 - pictBoxCal1.Height / 2)));
            pictBoxCal1.BackColor = Color.Red;

            timer1 = new System.Threading.Timer(new TimerCallback(Calibrate), null, 250, 25);
        }

        public int i = 0;
        private void Calibrate(object msg)
        {

            float formHeight = this.Height;
            float formWidth = this.Width;

            i++;
            Console.WriteLine(i);

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

                    pictBoxCal2.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal2.Location = new Point((int)(formWidth * 0.025 - pictBoxCal2.Width / 2), ((int)(formHeight * 0.025 - pictBoxCal2.Height / 2)));
                        pictBoxCal2.BackColor = Color.Red;
                    }));
                }
            }
            else if (pictBoxCal2.Width > 15)
            {
                pictBoxCal2.Invoke(new MethodInvoker(delegate
                {
                    pictBoxCal2.Width--;
                    pictBoxCal2.Height--;
                    pictBoxCal2.Location = new Point((int)(formWidth * 0.025 - pictBoxCal2.Width / 2), ((int)(formHeight * 0.025 - pictBoxCal2.Height / 2)));
                }));

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.025, 0.025);
                    pictBoxCal2.BackColor = Color.Green;

                    pictBoxCal3.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal3.Location = new Point((int)(formWidth * 0.025 - pictBoxCal3.Width / 2), ((int)(formHeight * 0.975 - pictBoxCal3.Height / 2)));
                        pictBoxCal3.BackColor = Color.Red;
                    }));
                }
            }
            else if (pictBoxCal3.Width > 15)
            {
                pictBoxCal3.Invoke(new MethodInvoker(delegate
                {
                    pictBoxCal3.Width--;
                    pictBoxCal3.Height--;
                    pictBoxCal3.Location = new Point((int)(formWidth * 0.025 - pictBoxCal3.Width / 2), ((int)(formHeight * 0.975 - pictBoxCal3.Height / 2)));
                }));

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.025, 0.975);
                    pictBoxCal3.BackColor = Color.Green;

                    pictBoxCal4.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal4.Location = new Point((int)(formWidth * 0.975 - pictBoxCal4.Width / 2), ((int)(formHeight * 0.975 - pictBoxCal4.Height / 2)));
                        pictBoxCal4.BackColor = Color.Red;
                    }));
                }
            }
            else if (pictBoxCal4.Width > 15)
            {
                pictBoxCal4.Invoke(new MethodInvoker(delegate
                {
                    pictBoxCal4.Width--;
                    pictBoxCal4.Height--;
                    pictBoxCal4.Location = new Point((int)(formWidth * 0.975 - pictBoxCal4.Width / 2), ((int)(formHeight * 0.975 - pictBoxCal4.Height / 2)));
                }));

                if (pictBoxCal4.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.975, 0.975);
                    pictBoxCal4.BackColor = Color.Green;

                    pictBoxCal5.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal5.Location = new Point((int)(formWidth * 0.975 - pictBoxCal5.Width / 2), ((int)(formHeight * 0.025 - pictBoxCal5.Height / 2)));
                        pictBoxCal5.BackColor = Color.Red;
                    }));
                }
            }
            else if (pictBoxCal5.Width > 15)
            {
                pictBoxCal5.Invoke(new MethodInvoker(delegate
                {
                    pictBoxCal5.Width--;
                    pictBoxCal5.Height--;
                    pictBoxCal5.Location = new Point((int)(formWidth * 0.975 - pictBoxCal5.Width / 2), ((int)(formHeight * 0.025 - pictBoxCal5.Height / 2)));
                }));

                if (pictBoxCal5.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.975, 0.025);
                    pictBoxCal5.BackColor = Color.Green;
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
