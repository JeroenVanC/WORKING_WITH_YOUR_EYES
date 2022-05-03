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
        public calibrationForm()
        {
            InitializeComponent();
            btnStartCal.Location = new Point(this.Width/2 - btnStartCal.Width / 2, 30);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
