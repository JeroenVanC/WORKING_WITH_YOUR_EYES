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
    /// Interaction logic for CalibrationWindow.xaml
    /// </summary>
    public partial class CalibrationWindow : Window
    {
        private Ellipse circleOne = new Ellipse();
        private Ellipse circleTwo = new Ellipse();
        private Ellipse circleThree = new Ellipse();
        private Ellipse circleFour = new Ellipse();
        private Ellipse circleFive = new Ellipse();
        public static Tuple<IntPtr, IntPtr> calConnection;
        private System.Threading.Timer timer1;
        public CalibrationWindow(Tuple<IntPtr, IntPtr> connection)
        {
            InitializeComponent();
            calConnection = connection;
        }


        private void btnStartCal_Click(object sender, RoutedEventArgs e)
        {
            TobiiTracker.startPersonCal(calConnection.Item1);

            // drawing circles transparant
            // circle 1
            initiateCircle(circleOne, 0.5, 0.5);
            circleOne.Fill = Brushes.Red;

            // circle 2
            initiateCircle(circleTwo, 0.025, 0.025);

            // circle 3
            initiateCircle(circleThree, 0.025, 0.975);

            // circle 4
            initiateCircle(circleFour, 0.975, 0.975);

            // circle 5
            initiateCircle(circleFive, 0.975, 0.025);

            timer1 = new Timer(new TimerCallback(Calibrate), null, 250, 25);
        }

        public void initiateCircle(Ellipse circle, double x, double y)
        {
            circle.Height = 100;
            circle.Width = 100;
            circle.Fill = Brushes.Transparent;
            Canvas.SetLeft(circle, Width * x - circle.Width / 2);
            Canvas.SetTop(circle, Height * y - circle.Width / 2);
            canvasCal.Children.Add(circle);
        }

        private void Calibrate(object msg)
        {

            if (circleOne.ActualWidth >= 15)
            {
                Dispatcher.Invoke(() =>
                {
                    circleOne.Width--;
                    circleOne.Height--;
                    Canvas.SetLeft(circleOne, Width * 0.5 - circleOne.Width / 2);
                    Canvas.SetTop(circleOne, Height * 0.5 - circleOne.Width / 2);

                });

                if (circleOne.ActualWidth == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.5, 0.5);
                    Dispatcher.Invoke(() =>
                    {
                        circleOne.Fill = Brushes.Green;

                        
                        circleTwo.Fill = Brushes.Red;
                        

                    });
                }
            }
            else if (circleTwo.ActualWidth >= 15)
            {
                Dispatcher.Invoke(() =>
                {
                    circleTwo.Width--;
                    circleTwo.Height--;
                    Canvas.SetLeft(circleTwo, Width * 0.025 - circleTwo.Width / 2);
                    Canvas.SetTop(circleTwo, Height * 0.025 - circleTwo.Width / 2);

                });

                if (circleTwo.ActualWidth == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.025, 0.025);
                    Dispatcher.Invoke(() =>
                    {
                        circleTwo.Fill = Brushes.Green;

                        circleThree.Fill = Brushes.Red;

                    });
                }
            }
            else if (circleThree.ActualWidth >= 15)
            {
                Dispatcher.Invoke(() =>
                {
                    circleThree.Width--;
                    circleThree.Height--;
                    Canvas.SetLeft(circleThree, Width * 0.025 - circleThree.Width / 2);
                    Canvas.SetTop(circleThree, Height * 0.975 - circleThree.Width / 2);

                });

                if (circleThree.ActualWidth == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.025, 0.975);
                    Dispatcher.Invoke(() =>
                    {
                        circleThree.Fill = Brushes.Green;

                        circleFour.Fill = Brushes.Red;

                    });
                }
            }
            else if (circleFour.ActualWidth >= 15)
            {
                Dispatcher.Invoke(() =>
                {
                    circleFour.Width--;
                    circleFour.Height--;
                    Canvas.SetLeft(circleFour, Width * 0.975 - circleFour.Width / 2);
                    Canvas.SetTop(circleFour, Height * 0.975 - circleFour.Width / 2);

                });

                if (circleFour.ActualWidth == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.975, 0.975);
                    Dispatcher.Invoke(() =>
                    {
                        circleFour.Fill = Brushes.Green;

                        circleFive.Fill = Brushes.Red;

                    });
                }
            }
            else if (circleFive.ActualWidth >= 15)
            {
                Dispatcher.Invoke(() =>
                {
                    circleFive.Width--;
                    circleFive.Height--;
                    Canvas.SetLeft(circleFive, Width * 0.975 - circleFive.Width / 2);
                    Canvas.SetTop(circleFive, Height * 0.025 - circleFive.Width / 2);

                });

                if (circleFive.ActualWidth == 15)
                {
                    TobiiTracker.calcPnt(calConnection.Item1, 0.975, 0.025);
                    Dispatcher.Invoke(() =>
                    {
                        circleFive.Fill = Brushes.Green;

                    });
                }
            }
            else
            {

                timer1.Change(Timeout.Infinite, Timeout.Infinite);
                TobiiTracker.computeApplyStopPersonCal(calConnection.Item1);

                Dispatcher.Invoke(() =>
                {
                    Close();
                });
            }
        }
    }

}
