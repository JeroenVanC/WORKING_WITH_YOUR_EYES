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
    public partial class testCalibrationForm : Form
    {

        private System.Threading.Timer timer;
        public int counter = 0;
        public string path = String.Format(@"C:\Users\jonas\SynologyDrive\GIT\WORKING_WITH_YOUR_EYES\Calibration\");

        public string filename = "test.txt";

        public testCalibrationForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            btnStartTestCal.Location = new Point(this.Width / 2 - btnStartTestCal.Width / 2, 30);
        }

        private void btnStartTestCal_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(path) && !Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //string time = DateTime.Now.ToString("yyyy-MM-dd");
            //File.WriteAllText(path + filename, time + "\n");
            //File.WriteAllText(path + filename, "test\n");
            timer = new System.Threading.Timer(new TimerCallback(StartTest), null, 250, 25);

        }


        private void StartTest(object msg)
        {
            float formHeight = this.Height;
            float formWidth = this.Width;
            int TimeRed = 40;
            int TimeOrange = 150;
            btnStartTestCal.Invoke(new MethodInvoker(delegate
            {
                btnStartTestCal.Hide();
            }));

            using (StreamWriter sw = File.AppendText(path+ filename))
            {
                sw.WriteLine(counter);
            }


            if (counter < TimeRed)
            {
                testCal1.Invoke(new MethodInvoker(delegate
                {
                    testCal1.Location = new Point((int)(formWidth * 0.05 - testCal1.Width / 2), ((int)(formHeight * 0.05 - testCal1.Height / 2)));
                    testCal1.BackColor = Color.Red;
                    testCal1.Visible = true;
                }));

            }
            else if (counter >= TimeRed && counter < (TimeRed + TimeOrange))
            {
                testCal1.Invoke(new MethodInvoker(delegate
                {
                    testCal1.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (TimeRed + TimeOrange) && counter < (2 * TimeRed + TimeOrange))
            {
                testCal1.Invoke(new MethodInvoker(delegate
                {
                    testCal1.BackColor = Color.Green;
                }));

                testCal2.Invoke(new MethodInvoker(delegate
                {
                    testCal2.Location = new Point((int)(formWidth * 0.05 - testCal1.Width / 2), ((int)(formHeight * 0.95 - testCal1.Height / 2)));
                    testCal2.BackColor = Color.Red;
                    testCal2.Visible = true;
                }));
            }
            else if (counter >= (2 * TimeRed + TimeOrange) && counter < (2 * TimeRed + 2 * TimeOrange))
            {
                testCal2.Invoke(new MethodInvoker(delegate
                {
                    testCal2.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (2 * TimeRed + 2 * TimeOrange) && counter < (3 * TimeRed + 2 * TimeOrange))
            {
                testCal2.Invoke(new MethodInvoker(delegate
                {
                    testCal2.BackColor = Color.Green;
                }));

                testCal3.Invoke(new MethodInvoker(delegate
                {
                    testCal3.Location = new Point((int)(formWidth * 0.95 - testCal1.Width / 2), ((int)(formHeight * 0.05 - testCal1.Height / 2)));
                    testCal3.BackColor = Color.Red;
                    testCal3.Visible = true;
                }));
            }
            else if (counter >= (3 * TimeRed + 2 * TimeOrange) && counter < (3 * TimeRed + 3 * TimeOrange))
            {
                testCal3.Invoke(new MethodInvoker(delegate
                {
                    testCal3.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (3 * TimeRed + 3 * TimeOrange) && counter < (4 * TimeRed + 3 * TimeOrange))
            {
                testCal3.Invoke(new MethodInvoker(delegate
                {
                    testCal3.BackColor = Color.Green;
                }));

                testCal4.Invoke(new MethodInvoker(delegate
                {
                    testCal4.Location = new Point((int)(formWidth * 0.95 - testCal1.Width / 2), ((int)(formHeight * 0.95 - testCal1.Height / 2)));
                    testCal4.BackColor = Color.Red;
                    testCal4.Visible = true;
                }));
            }
            else if (counter >= (4 * TimeRed + 3 * TimeOrange) && counter < (4 * TimeRed + 4 * TimeOrange))
            {
                testCal4.Invoke(new MethodInvoker(delegate
                {
                    testCal4.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (4 * TimeRed + 4 * TimeOrange) && counter < (5 * TimeRed + 4 * TimeOrange))
            {
                testCal4.Invoke(new MethodInvoker(delegate
                {
                    testCal4.BackColor = Color.Green;
                }));

                testCal5.Invoke(new MethodInvoker(delegate
                {
                    testCal5.Location = new Point((int)(formWidth * 0.5 - testCal1.Width / 2), ((int)(formHeight * 0.5 - testCal1.Height / 2)));
                    testCal5.BackColor = Color.Red;
                    testCal5.Visible = true;
                }));
            }
            else if (counter >= (5 * TimeRed + 4 * TimeOrange) && counter < (5 * TimeRed + 5 * TimeOrange))
            {
                testCal5.Invoke(new MethodInvoker(delegate
                {
                    testCal5.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (5 * TimeRed + 5 * TimeOrange) && counter < (6 * TimeRed + 5 * TimeOrange))
            {
                testCal5.Invoke(new MethodInvoker(delegate
                {
                    testCal5.BackColor = Color.Green;
                }));

                testCal6.Invoke(new MethodInvoker(delegate
                {
                    testCal6.Location = new Point((int)(formWidth * 0.25 - testCal1.Width / 2), ((int)(formHeight * 0.5 - testCal1.Height / 2)));
                    testCal6.BackColor = Color.Red;
                    testCal6.Visible = true;
                }));
            }
            else if (counter >= (6 * TimeRed + 5 * TimeOrange) && counter < (6 * TimeRed + 6 * TimeOrange))
            {
                testCal6.Invoke(new MethodInvoker(delegate
                {
                    testCal6.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (6 * TimeRed + 6 * TimeOrange) && counter < (7 * TimeRed + 6 * TimeOrange))
            {
                testCal6.Invoke(new MethodInvoker(delegate
                {
                    testCal6.BackColor = Color.Green;
                }));

                testCal7.Invoke(new MethodInvoker(delegate
                {
                    testCal7.Location = new Point((int)(formWidth * 0.5 - testCal1.Width / 2), ((int)(formHeight * 0.25 - testCal1.Height / 2)));
                    testCal7.BackColor = Color.Red;
                    testCal7.Visible = true;
                }));
            }
            else if (counter >= (7 * TimeRed + 6 * TimeOrange) && counter < (7 * TimeRed + 7 * TimeOrange))
            {
                testCal7.Invoke(new MethodInvoker(delegate
                {
                    testCal7.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (7 * TimeRed + 7 * TimeOrange) && counter < (8 * TimeRed + 7 * TimeOrange))
            {
                testCal7.Invoke(new MethodInvoker(delegate
                {
                    testCal7.BackColor = Color.Green;
                }));

                testCal8.Invoke(new MethodInvoker(delegate
                {
                    testCal8.Location = new Point((int)(formWidth * 0.75 - testCal1.Width / 2), ((int)(formHeight * 0.5 - testCal1.Height / 2)));
                    testCal8.BackColor = Color.Red;
                    testCal8.Visible = true;
                }));
            }
            else if (counter >= (8 * TimeRed + 7 * TimeOrange) && counter < (8 * TimeRed + 8 * TimeOrange))
            {
                testCal8.Invoke(new MethodInvoker(delegate
                {
                    testCal8.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (8 * TimeRed + 8 * TimeOrange) && counter < (9 * TimeRed + 8 * TimeOrange))
            {
                testCal8.Invoke(new MethodInvoker(delegate
                {
                    testCal8.BackColor = Color.Green;
                }));

                testCal9.Invoke(new MethodInvoker(delegate
                {
                    testCal9.Location = new Point((int)(formWidth * 0.5 - testCal1.Width / 2), ((int)(formHeight * 0.75 - testCal1.Height / 2)));
                    testCal9.BackColor = Color.Red;
                    testCal9.Visible = true;
                }));
            }
            else if (counter >= (9 * TimeRed + 8 * TimeOrange) && counter < (9 * TimeRed + 9 * TimeOrange))
            {
                testCal9.Invoke(new MethodInvoker(delegate
                {
                    testCal9.BackColor = Color.Orange;
                }));
            }
            else if (counter >= (9 * TimeRed + 9 * TimeOrange) && counter < (10 * TimeRed + 9 * TimeOrange))
            {
                testCal9.Invoke(new MethodInvoker(delegate
                {
                    testCal9.BackColor = Color.Green;
                }));

            } else
            {
                timer.Change(Timeout.Infinite, Timeout.Infinite);
            }

            counter++;
            

        }
    }
}
