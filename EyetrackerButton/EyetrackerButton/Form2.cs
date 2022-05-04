using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EyetrackerButton
{
    public partial class Form2 : Form
    {
        public static Tuple<IntPtr, IntPtr> calConnection;

        private static TimerCallback timerCallback = new TimerCallback(timerCount);
        private System.Threading.Timer timer1;
        public Thread threadCallibration;
        public static int count = 150;

        public Form2(Tuple<IntPtr, IntPtr> connection)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            calConnection = connection;

            threadCallibration = new Thread(new ThreadStart(Calibrate));


        }

        

        private void btnStartCal_Click(object sender, EventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);

            float formHeight = this.Height;
            float formWidth = this.Width;
            count = 150;

            pictBoxCal1.Location = new Point((int)(formWidth * 0.5 - pictBoxCal1.Width/2), ((int)(formHeight * 0.5 - pictBoxCal1.Height/2)));
            pictBoxCal1.BackColor = Color.Red;

            threadCallibration.Start();

            //timer1 = new System.Threading.Timer(timerCallback, null, 250, 16);
        }

      


        private void btnStopCal_Click(object sender, EventArgs e)
        {
            TobiiTracker.computeApplyStopPersonCal(calConnection.Item1);
            this.Close();
        }

        private void pictBoxCalibration_Click(object sender, EventArgs e)
        {
            TobiiTracker.calcPnt(calConnection.Item1, 0.5, 0.5);
            pictBoxCal1.BackColor = Color.Green;

        }

        private void pictBoxCal2_Click(object sender, EventArgs e)
        {
            TobiiTracker.calcPnt(calConnection.Item1, 0.025, 0.025);
            pictBoxCal2.BackColor = Color.Green;
        }

        private void pictBoxCal3_Click(object sender, EventArgs e)
        {
            TobiiTracker.calcPnt(calConnection.Item1, 0.025, 0.975);
            pictBoxCal3.BackColor = Color.Green;
        }
        private void pictBoxCal4_Click(object sender, EventArgs e)
        {
            TobiiTracker.calcPnt(calConnection.Item1, 0.975, 0.975);
            pictBoxCal4.BackColor = Color.Green;
        }
        private void pictBoxCal5_Click(object sender, EventArgs e)
        {
            TobiiTracker.calcPnt(calConnection.Item1, 0.975, 0.025);
            pictBoxCal5.BackColor = Color.Green;
        }



        private static void timerCount(object msg)
        {
            count--;
        }


        public int i = 0;
        private void Calibrate()
        {
            while (true)
            {
                float formHeight = this.Height;
                float formWidth = this.Width;

                Console.WriteLine(count);

                if (pictBoxCal1.Width > 15)
                {
                    pictBoxCal1.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal1.Width = count;
                        pictBoxCal1.Height = count;
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

                        count = 150;
                    }
                }
                else if (pictBoxCal2.Width > 15)
                {
                    pictBoxCal2.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal2.Width = count;
                        pictBoxCal2.Height = count;
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

                        count = 150;
                    }
                }
                else if (pictBoxCal3.Width > 15)
                {
                    pictBoxCal3.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal3.Width = count;
                        pictBoxCal3.Height = count;
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

                        count = 150;
                    }
                }
                else if (pictBoxCal4.Width > 15)
                {
                    pictBoxCal4.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal4.Width = count;
                        pictBoxCal4.Height = count;
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

                        count = 150;
                    }
                }
                else if (pictBoxCal5.Width > 15)
                {
                    pictBoxCal5.Invoke(new MethodInvoker(delegate
                    {
                        pictBoxCal5.Width = count;
                        pictBoxCal5.Height = count;
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
                    break;
                }
            }

            threadCallibration.Abort();

        }
    }
}
