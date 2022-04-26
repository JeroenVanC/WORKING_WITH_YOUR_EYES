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


            pictBoxCal1.Location = new Point((int)(formWidth * 0.5), ((int)(formHeight * 0.5)));
            pictBoxCal1.BackColor = Color.Red;

            pictBoxCal2.Location = new Point((int)(formWidth * 0.025), ((int)(formHeight * 0.025)));
            pictBoxCal2.BackColor = Color.Red;

            pictBoxCal3.Location = new Point((int)(formWidth * 0.025), ((int)(formHeight * 0.975)));
            pictBoxCal3.BackColor = Color.Red;

            pictBoxCal4.Location = new Point((int)(formWidth * 0.975), ((int)(formHeight * 0.975)));
            pictBoxCal4.BackColor = Color.Red;

            pictBoxCal5.Location = new Point((int)(formWidth * 0.975), ((int)(formHeight * 0.025)));
            pictBoxCal5.BackColor = Color.Red;

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

        
    }
}
