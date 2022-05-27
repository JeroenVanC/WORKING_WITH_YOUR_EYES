using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace WorkingWithYourEyesWPF
{
    class ButtonInit
    {
        public void init(Tuple<IntPtr, IntPtr> demoConnection, float xGaze, float yGaze, float xMovingAverage, float yMovingAverage, 
            MovingAverage xAverageGaze, MovingAverage yAverageGaze, MovingAverage xAverage, MovingAverage yAverage, Window window, 
            Ellipse gazeBox, NextButtonHandler buttonHandlerNext, NextButtonHandler buttonHandlerBack)
        {
            TobiiTracker.record(demoConnection.Item1);

            // rooie vierkant
            xGaze = xAverageGaze.Next(TobiiTracker.coordinaat_x);
            yGaze = yAverageGaze.Next(TobiiTracker.coordinaat_y);

            // blauwe vierkant
            xMovingAverage = xAverage.Next(TobiiTracker.coordinaat_x);
            yMovingAverage = yAverage.Next(TobiiTracker.coordinaat_y);

            double formHeight = window.ActualHeight;
            double formWidth = window.ActualWidth;

            window.Dispatcher.Invoke(() =>
            {
                var xCoor = (double)formWidth * TobiiTracker.coordinaat_x - gazeBox.Width / 2;
                var yCoor = (double)formHeight * TobiiTracker.coordinaat_y - gazeBox.Height / 2;
                Canvas.SetLeft(gazeBox, xCoor);
                Canvas.SetTop(gazeBox, yCoor);
            });

            bool btnActive;
            //btnActive = checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp);

            // button handler
            if (buttonHandlerBack.checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp, btnBack, 1000000, false))
            {
                window.Dispatcher.Invoke(() =>
                {
                    //backFunc();
                });

            }
            else if (buttonHandlerNext.checkIfBtnActive(xGaze, yGaze, xMovingAverage, yMovingAverage, TobiiTracker.timestamp, btnNext, 1000000, false))
            {
                window.Dispatcher.Invoke(() =>
                {
                    //nextFunc();
                });
            };
        }
    }
}
