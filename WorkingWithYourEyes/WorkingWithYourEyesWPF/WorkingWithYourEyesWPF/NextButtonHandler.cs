using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WorkingWithYourEyesWPF
{
    class NextButtonHandler
    {
        private Window mainWindow;

        //btn state
        public bool btnActiveState = false;
        public long beginTime = 0;
        public long activeTime = 0;

        //// rooie vierkant
        //public MovingAverage xAverageGaze = new MovingAverage(10);
        //public MovingAverage yAverageGaze = new MovingAverage(10);

        //// blauwe vierkant
        //public MovingAverage xAverage = new MovingAverage(150);
        //public MovingAverage yAverage = new MovingAverage(150);

        private bool nextBtnActive = false;
        bool output = false;
        public NextButtonHandler(Window window, int AvgGaze, int Avg)
        {
            mainWindow = window;

            //xAverageGaze = new MovingAverage(AvgGaze);
            //yAverageGaze = new MovingAverage(AvgGaze);

            //xAverage = new MovingAverage(Avg);
            //yAverage = new MovingAverage(Avg);
        }

        public bool checkIfBtnActive(float xGaze, float yGaze, float xMovingAverage, float yMovingAverage, long timestamp, Button btnNext, int time, bool border)
        {

            int btnSizeX_left = 0;
            int btnSizeY_top = 0;
            int btnSizeX_right = 0;
            int btnSizeY_bottem = 0;

            mainWindow.Dispatcher.Invoke(() =>
            {
                btnSizeX_left = (int)Canvas.GetLeft(btnNext);
                btnSizeY_top = (int)Canvas.GetTop(btnNext); ;
                btnSizeX_right = (int)Canvas.GetLeft(btnNext) + (int)btnNext.Width;
                btnSizeY_bottem = (int)Canvas.GetTop(btnNext) + (int)btnNext.Height;
            });

            int xGazePixel = (int)(mainWindow.ActualWidth * xGaze);
            int yGazePixel = (int)(mainWindow.ActualHeight * yGaze);

            int xMovingAvgPixel = (int)(mainWindow.ActualWidth * xMovingAverage);
            int yMovingAvgPixel = (int)(mainWindow.ActualHeight * yMovingAverage);

            if (btnSizeX_left < xGazePixel && xGazePixel < btnSizeX_right && btnSizeY_top < yGazePixel && yGazePixel < btnSizeY_bottem)
            {
                if (btnActiveState)
                {
                    activeTime = timestamp - beginTime;

                    byte activeTimeByteR = (byte)(activeTime / (time / (-120)) + 197);
                    byte activeTimeByteG = (byte)(activeTime / (time / 174) + 38);
                    byte activeTimeByteB = (byte)(activeTime / (time / 9) + 38);

                    mainWindow.Dispatcher.Invoke(() =>
                    {
                        if (border)
                        {
                            btnNext.BorderBrush = new SolidColorBrush(Color.FromRgb(activeTimeByteR, activeTimeByteG, activeTimeByteB));

                        }
                        else
                        {
                            btnNext.Background = new SolidColorBrush(Color.FromRgb(activeTimeByteR, activeTimeByteG, activeTimeByteB));

                        }
                    });

                    if (activeTime > time && nextBtnActive == false)
                    {
                        mainWindow.Dispatcher.Invoke(() =>
                        {

                            if (border)
                            {
                                btnNext.BorderBrush = Brushes.Red;

                            }
                            else
                            {
                                btnNext.Background = Brushes.Red;

                            }
                            btnActiveState = false;
                            output = true;
                        });
                        beginTime = 0;
                    }
                }
                else
                {
                    beginTime = timestamp;
                    btnActiveState = true;
                }
            }
            else if (btnSizeX_left < xMovingAvgPixel && xMovingAvgPixel < btnSizeX_right && btnSizeY_top < yMovingAvgPixel && yMovingAvgPixel < btnSizeY_bottem)
            {
                btnActiveState = true;
            }
            else
            {
                mainWindow.Dispatcher.Invoke(() =>
                {
                    if (border)
                    {
                        btnNext.BorderBrush = new SolidColorBrush(Color.FromRgb(197, 38, 38));
                    }
                    else
                    {
                        btnNext.Background = new SolidColorBrush(Color.FromRgb(197, 38, 38));
                    }
                });

                btnActiveState = false;
            }
            return output;
        }




    }
}