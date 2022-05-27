using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkingWithYourEyesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public TobiiTracker tobiiTracker = new TobiiTracker();

        public Tuple<IntPtr, IntPtr> connection;

        public int btnColorCounter = 0;

        private int mainWindowBtnState;

        public MainWindow()
        {
            InitializeComponent();
            
            mainWindowBtnState = 1;
            updateWindowBtnState(mainWindowBtnState);
        }


        private void updateWindowBtnState(int state)
        {
            if (state == 1)
            {
                btnConnect.Visibility = Visibility.Visible;
                btnCalibrate.Visibility = Visibility.Hidden;
                btnStartDemo.Visibility = Visibility.Collapsed;
                btnDisconnect.Visibility = Visibility.Hidden;
                lblInfo_second.Visibility = Visibility.Collapsed;
                lblInfo.Content = "Press the connect button to connect with the eye tracker.";
            }
            else if (state == 2)
            {
                btnCalibrate.Visibility = Visibility.Visible;
                btnDisconnect.Visibility = Visibility.Visible;

                btnStartDemo.Visibility = Visibility.Collapsed;
                btnConnect.Visibility = Visibility.Hidden;

                lblInfo_second.Visibility = Visibility.Collapsed;
                lblInfo.Content = "Press he calibrate button to improve the eyetracking.";
            }
            else if (state == 3)
            {
                btnCalibrate.Visibility = Visibility.Visible;
                btnDisconnect.Visibility = Visibility.Visible;

                btnStartDemo.Visibility = Visibility.Visible;
                btnConnect.Visibility = Visibility.Hidden;

                lblInfo_second.Visibility = Visibility.Visible;

            }
        }
        private void btnExitFS_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("clicked");
            
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            // connection.Item1 =  deviceContext & connection.Item2 = apiContext
            //thread = new Thread(new ThreadStart(recording));
            connection = TobiiTracker.subscribe();

            mainWindowBtnState = 3; // deze op 2 zetten 3 is effe voor te testen
            updateWindowBtnState(mainWindowBtnState);
        }

        private void btnCalibrate_Click(object sender, RoutedEventArgs e)
        {
            var calibrationWindow = new CalibrationWindow(connection);
            calibrationWindow.Show();

            mainWindowBtnState = 3;
            updateWindowBtnState(mainWindowBtnState);
        }

        private void btnStartDemo_Click(object sender, RoutedEventArgs e)
        {
            var demoWindow = new DemoWindow(connection);
            demoWindow.Show();
        }

        private void btnColorChanger_Click(object sender, RoutedEventArgs e)
        {
            if (btnColorCounter == 8)
            {
                btnColorCounter = 0;
            }
            btnColorCounter++;

            byte rgbByte = (byte)(btnColorCounter * 32);

            btnConnect.Background = new SolidColorBrush(Color.FromArgb(255, 0, rgbByte , 0)); ;
        }

        private void mainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                WindowStyle = WindowStyle.SingleBorderWindow;
            }
        }

        private void btnDisconnect_Click(object sender, RoutedEventArgs e)
        {
            TobiiTracker.unsubscribe(connection.Item1, connection.Item2);
            mainWindowBtnState = 1;
            updateWindowBtnState(mainWindowBtnState);
        }
    }
}
