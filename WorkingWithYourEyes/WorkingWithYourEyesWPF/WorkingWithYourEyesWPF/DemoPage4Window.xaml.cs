﻿using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for DemoPage4Window.xaml
    /// </summary>
    public partial class DemoPage4Window : Window
    {
        public static Tuple<IntPtr, IntPtr> demoConnection;

        private System.Threading.Timer timer1;

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
        private bool nextBtnActive = false;

        private NextButtonHandler buttonHandlerNext;
        private NextButtonHandler buttonHandlerBack;

        private bool nextActive = false;
        private bool backActive = false;

        public List<string> coordinates = new List<string>();
        public string path = String.Format(@"C:\Users\jonas\SynologyDrive\GIT\WORKING_WITH_YOUR_EYES\WorkingWithYourEyes\WorkingWithYourEyesWPF\WorkingWithYourEyesWPF\Data\");

        public DemoPage4Window(Tuple<IntPtr, IntPtr> connection)
        {
            InitializeComponent();
            demoConnection = connection;
            buttonHandlerNext = new NextButtonHandler(this, 10, 150);
            buttonHandlerBack = new NextButtonHandler(this, 10, 150);

            if (!string.IsNullOrWhiteSpace(path) && !Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            timer1 = new System.Threading.Timer(new TimerCallback(recording), null, 250, 5);
        }

        private void printCoorToArray()
        {

            coordinates.Add((int)(TobiiTracker.coordinaat_x * 1920) + "," + (int)(TobiiTracker.coordinaat_y * 1080));

        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void writeArrayToFile()
        {

            String timeStamp = GetTimestamp(DateTime.Now);
            String fullPath = path + "page4_" + timeStamp + ".csv";

            using (StreamWriter outputFile = new StreamWriter(fullPath))
            {
                outputFile.WriteLine("x,y");
                for (int i = 0; i < coordinates.Count; i++)
                {
                    outputFile.WriteLine(coordinates[i]);
                }
            }
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
            if (buttonHandlerBack.checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp, btnBack, 1000000, false) && backActive == false)
            {
                backActive = true;
                Dispatcher.Invoke(() =>
                {
                    backFunc();
                });

            }
            else if (buttonHandlerNext.checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp, btnNext, 1000000, false) && nextActive == false)
            {
                nextActive = true;
                Dispatcher.Invoke(() =>
                {
                    nextFunc();
                });
            };

            printCoorToArray();
        }

        private void nextFunc()
        {
            timer1.Change(Timeout.Infinite, Timeout.Infinite);
            writeArrayToFile();
            var nextWindow = new DemoPage5Window(demoConnection);
            nextWindow.Show();
            Close();
        }

        public void backFunc()
        {
            timer1.Change(Timeout.Infinite, Timeout.Infinite);
            writeArrayToFile();
            var nextWindow = new DemoPage3Window(demoConnection);
            nextWindow.Show();
            Close();
        }
    }
}
