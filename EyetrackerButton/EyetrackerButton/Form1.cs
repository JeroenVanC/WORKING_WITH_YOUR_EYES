using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Tobii.StreamEngine;
using System.Threading;

namespace EyetrackerButton
{
    public partial class Form1 : Form
    {
        public TobiiTracker tobiiTracker = new TobiiTracker();
        public Thread thread;
        public Tuple<IntPtr, IntPtr> connection;

        public Form1()
        {
            InitializeComponent();

            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //TopMost = true;



            thread = new Thread(new ThreadStart(recording));

        }

        public void btnRecord_Click(object sender, EventArgs e)
        {

            thread.Start();
            
            
        }

        public void recording()
        {
            while (true)
            {
                TobiiTracker.record(connection.Item1);
                Console.WriteLine($"Gaze point: {TobiiTracker.coordinaat_x}, {TobiiTracker.coordinaat_y}");

                // update x-coor label
                if (lblX_Val.InvokeRequired)
                    lblX_Val.Invoke(new MethodInvoker(delegate { lblX_Val.Text = TobiiTracker.coordinaat_x.ToString("0.0000000"); }));
                else
                    lblX_Val.Text = "ERROR";

                // update y-coor label
                if (lblY_val.InvokeRequired)
                    lblY_val.Invoke(new MethodInvoker(delegate { lblY_val.Text = TobiiTracker.coordinaat_y.ToString("0.0000000"); }));
                else
                    lblY_val.Text = "ERROR";

                float formHeight = this.Height;
                float formWidth = this.Width;

                gazeBox.Invoke(new MethodInvoker(delegate { gazeBox.Location = new Point((int)(formWidth * TobiiTracker.coordinaat_x), ((int)(formHeight * TobiiTracker.coordinaat_y))); }));

                

            }
        }

        public void btnDisconnect_Click(object sender, EventArgs e)
        {
            thread.Abort();
            TobiiTracker.unsubscribe(connection.Item1, connection.Item2);
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            // connection.Item1 =  deviceContext & connection.Item2 = apiContext
            connection = TobiiTracker.subscribe();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }
    }
}
