using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyetrackerButton
{
    public partial class Form2 : Form
    {
        public static Tuple<IntPtr, IntPtr> calConnection;
       

        public Form2(Tuple<IntPtr, IntPtr> connection)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            calConnection = connection;
            

        }

        

        private void btnStartCal_Click(object sender, EventArgs e)
        {

            float formHeight = this.Height;
            float formWidth = this.Width;
            timer1.Enabled = true;


            pictBoxCal1.Location = new Point((int)(formWidth * 0.5 - pictBoxCal1.Width/2), ((int)(formHeight * 0.5 - pictBoxCal1.Height/2)));
            pictBoxCal1.BackColor = Color.Red;

            TobiiTracker.startPersonCal(calConnection.Item1);
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            float formHeight = this.Height;
            float formWidth = this.Width;

            if (pictBoxCal1.Width > 15)
            {
                pictBoxCal1.Width--;
                pictBoxCal1.Height--;
                pictBoxCal1.Location = new Point((int)(formWidth * 0.5 - pictBoxCal1.Width / 2), ((int)(formHeight * 0.5 - pictBoxCal1.Height / 2)));
                pictBoxCal1.Update();

                if (pictBoxCal1.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.5, 0.5);
                    pictBoxCal1.BackColor = Color.Green;

                    pictBoxCal2.Location = new Point((int)(formWidth * 0.025 - pictBoxCal2.Width / 2), ((int)(formHeight * 0.025 - pictBoxCal2.Height / 2)));
                    pictBoxCal2.BackColor = Color.Red;
                }
            } else if (pictBoxCal2.Width > 15)
            {
                pictBoxCal2.Width--;
                pictBoxCal2.Height--;
                pictBoxCal2.Location = new Point((int)(formWidth * 0.025 - pictBoxCal2.Width / 2), ((int)(formHeight * 0.025 - pictBoxCal2.Height / 2)));

                if (pictBoxCal2.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.025, 0.025);
                    pictBoxCal2.BackColor = Color.Green;

                    pictBoxCal3.Location = new Point((int)(formWidth * 0.025 - pictBoxCal3.Width / 2), ((int)(formHeight * 0.975 - pictBoxCal3.Height / 2)));
                    pictBoxCal3.BackColor = Color.Red;
                }
            } else if (pictBoxCal3.Width > 15)
            {
                pictBoxCal3.Width--;
                pictBoxCal3.Height--;
                pictBoxCal3.Location = new Point((int)(formWidth * 0.025 - pictBoxCal3.Width / 2), ((int)(formHeight * 0.975 - pictBoxCal3.Height / 2)));

                if (pictBoxCal3.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.025, 0.975);
                    pictBoxCal3.BackColor = Color.Green;

                    pictBoxCal4.Location = new Point((int)(formWidth * 0.975 - pictBoxCal4.Width / 2), ((int)(formHeight * 0.975 - pictBoxCal4.Height / 2)));
                    pictBoxCal4.BackColor = Color.Red;
                }
            } else if (pictBoxCal4.Width > 15)
            {
                pictBoxCal4.Width--;
                pictBoxCal4.Height--;
                pictBoxCal4.Location = new Point((int)(formWidth * 0.975 - pictBoxCal4.Width / 2), ((int)(formHeight * 0.975 - pictBoxCal4.Height / 2)));

                if (pictBoxCal4.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.975, 0.975);
                    pictBoxCal4.BackColor = Color.Green;

                    pictBoxCal5.Location = new Point((int)(formWidth * 0.975 - pictBoxCal5.Width / 2), ((int)(formHeight * 0.025 - pictBoxCal5.Height / 2)));
                    pictBoxCal5.BackColor = Color.Red;
                }
            } else if (pictBoxCal5.Width > 15)
            {
                pictBoxCal5.Width--;
                pictBoxCal5.Height--;
                pictBoxCal5.Location = new Point((int)(formWidth * 0.975 - pictBoxCal5.Width / 2), ((int)(formHeight * 0.025 - pictBoxCal5.Height / 2)));

                if (pictBoxCal5.Width == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.975, 0.025);
                    pictBoxCal5.BackColor = Color.Green;
                }
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}
