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
            pictBoxCalibration.SizeMode = PictureBoxSizeMode.CenterImage;
            calConnection = connection;

            //Console.WriteLine("DEVICE CONTEXt: " + connection.Item1);

            
        }

        private void pictBoxCalibration_Click(object sender, EventArgs e)
        {
            // TobiiTracker.calibrateFirst(calConnection.Item1, calConnection.Item2);

            Console.WriteLine(calConnection.Item1 + " | " + calConnection.Item2);

            TobiiTracker.calibrateFirst(calConnection.Item1, calConnection.Item2);

        }
    }
}
