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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalibr_Click(object sender, EventArgs e)
        {
            
            calibrationForm calibrationForm = new calibrationForm();
            calibrationForm.ShowDialog(); // Shows Form2
            
        }

        private void panelBG_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        

        private void startForm_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void startForm_MouseMove(object sender, MouseEventArgs e)
        {
            panelGazeDir.Location = new Point(e.X - panelGazeDir.Width / 2, e.Y - panelGazeDir.Height / 2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int x = panelGazeDir.Width  / 2;
            int y = panelGazeDir.Height / 2;
            int width = 20;
            int height = 20;

            Pen pen = new Pen(Color.DarkBlue, 3);
            e.Graphics.DrawEllipse(pen, x - width / 2, y - height / 2, width, height);

            e.Graphics.Dispose();
        }
    }
    
}
