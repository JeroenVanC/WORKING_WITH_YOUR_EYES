using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WorkingWithYourEyesWPF
{
    /// <summary>
    /// Interaction logic for DemoWindow.xaml
    /// </summary>
    public partial class DemoWindow : Window
    {

        public static Tuple<IntPtr, IntPtr> demoConnection;

        //btn state
        public bool btnActiveState = false;
        public long beginTime = 0;
        public long activeTime = 0;

        // rooie vierkant
        public MovingAverage xAverageGaze = new MovingAverage(10);
        public MovingAverage yAverageGaze = new MovingAverage(10);

        public float xGaze;
        public float yGaze;

        // blauwe vierkant
        public MovingAverage xAverage = new MovingAverage(150);
        public MovingAverage yAverage = new MovingAverage(150);

        public float xMovingAverage;
        public float yMovingAverage;
        private bool nextActive = false;

        private NextButtonHandler buttonHandler;

        private System.Threading.Timer timer1;
        public DemoWindow(Tuple<IntPtr, IntPtr> connection)
        {
            InitializeComponent();
            demoConnection = connection;

            //thread.Start();
            timer1 = new Timer(new TimerCallback(recording), null, 250, 5);
            buttonHandler = new NextButtonHandler(this, 10 ,150);
        }

        public void recording(object msg)
        {
            TobiiTracker.record(demoConnection.Item1);

            // rooie vierkant
            xGaze = xAverageGaze.Next(TobiiTracker.coordinaat_x);
            yGaze = yAverageGaze.Next(TobiiTracker.coordinaat_y);

            // blauwe vierkant
            xMovingAverage = xAverage.Next(TobiiTracker.coordinaat_x);
            yMovingAverage = yAverage.Next(TobiiTracker.coordinaat_y);

            double formHeight = ActualHeight;
            double formWidth = ActualWidth;
  
            Dispatcher.Invoke(() =>
            {
                var xCoor = (double)formWidth * TobiiTracker.coordinaat_x - gazeBox.Width / 2;
                var yCoor = (double)formHeight * TobiiTracker.coordinaat_y - gazeBox.Height / 2;
                Canvas.SetLeft(gazeBox, xCoor);
                Canvas.SetTop(gazeBox, yCoor);
            });

            bool btnActive;
            //btnActive = checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp);

            // button handler
            if(buttonHandler.checkIfBtnActive(xGaze,yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp, btnStartDemo, 2500000, true) && nextActive == false)
            {
                nextActive = true;
                Dispatcher.Invoke(() => 
                {
                    nextFunc();
                });
            };
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            nextFunc();
        }

        public void nextFunc()
        {

            timer1.Change(Timeout.Infinite, Timeout.Infinite);
            var nextWindow = new DemoPage2Window(demoConnection);
            nextWindow.Show();
            Close();

        }


    }


}
