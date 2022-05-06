using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instructionForm
{
    public partial class calibrationForm : Form
    {
        public static Tuple<IntPtr, IntPtr> calConnection;
        public calibrationForm(Tuple<IntPtr, IntPtr> connection)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            btnStartCal.Location = new Point(this.Width/2 - btnStartCal.Width / 2, 30);

            calConnection = connection;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
