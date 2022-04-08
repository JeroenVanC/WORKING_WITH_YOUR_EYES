﻿using System;
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

namespace EyetrackerButton
{
    public partial class Form1 : Form
    {
        public IntPtr deviceContext;
        public tobii_error_t result;
        public IntPtr apiContext;
        public bool _stopTracking;
        public Form1()
        {
            InitializeComponent();
            



        }

        public static IntPtr CreateTrackerWithLicense(IntPtr api, string url, string licenseFileName)
        {
            var licenseResults = new List<tobii_license_validation_result_t>();
            var licenseContents = File.ReadAllText(licenseFileName, Encoding.Unicode);
            var resultCode = Interop.tobii_device_create_ex(
                api,
                url,
                Interop.tobii_field_of_use_t.TOBII_FIELD_OF_USE_STORE_OR_TRANSFER_FALSE,
                new[] { licenseContents },
                licenseResults,
                out var device);

            Debug.Assert(resultCode == tobii_error_t.TOBII_ERROR_NO_ERROR);
            return device;
        }

        private void OnGazePoint(ref tobii_gaze_point_t gazePoint, IntPtr userData)
        {
            // Check that the data is valid before using it
            if (gazePoint.validity == tobii_validity_t.TOBII_VALIDITY_VALID)
            {
                //Console.WriteLine($"Gaze point: {gazePoint.position.x}, {gazePoint.position.y}");
                if (gazePoint.position.x < 0.5 & gazePoint.position.y < 0.5)
                {
                    Console.WriteLine("LINKS BOVEN");

                    //if (lblGazeDir.InvokeRequired)
                    //    lblGazeDir.Invoke(new MethodInvoker(delegate { lblGazeDir.Text = "LINKS BOVEN"; }));
                    //else
                    //    lblGazeDir.Text = "ERROR";
                    //lblGazeDir.Text = "LINKS BOVEN";

                }
                else if (gazePoint.position.x < 0.5 & gazePoint.position.y > 0.5)
                {
                    Console.WriteLine("LINKS ONDER");
                    //if (lblGazeDir.InvokeRequired)
                    //    lblGazeDir.Invoke(new MethodInvoker(delegate { lblGazeDir.Text = "LINKS ONDER"; }));
                    //else
                    //    lblGazeDir.Text = "ERROR";
                    //lblGazeDir.Text = "LINKS ONDER";

                }

                else if (gazePoint.position.x > 0.5 & gazePoint.position.y > 0.5)
                {
                    Console.WriteLine("RECHTS ONDER");
                    //if (lblGazeDir.InvokeRequired)
                    //    lblGazeDir.Invoke(new MethodInvoker(delegate { lblGazeDir.Text = "RECHTS ONDER"; }));
                    //else
                    //    lblGazeDir.Text = "ERROR";
                    //lblGazeDir.Text = "RECHT ONDER";

                }
                else if (gazePoint.position.x > 0.5 & gazePoint.position.y < 0.5)
                {

                    Console.WriteLine("RECHTS BOVEN");
                    //if (lblGazeDir.InvokeRequired)
                    //    lblGazeDir.Invoke(new MethodInvoker(delegate { lblGazeDir.Text = "RECHTS BOVEN"; }));
                    //else
                    //    lblGazeDir.Text = "ERROR";
                    //lblGazeDir.Text = "RECHTS BOVEN";

                }
                else
                {
                    Console.WriteLine("ERROR!");
                    //if (lblGazeDir.InvokeRequired)
                    //    lblGazeDir.Invoke(new MethodInvoker(delegate { lblGazeDir.Text = "ERROR_!"; }));
                    //else
                    //    lblGazeDir.Text = "ERROR";
                    //lblGazeDir.Text = "ERROR";

                }
            }
        }

        private async void btnClickMe_Click(object sender, EventArgs e)
        {
            _stopTracking = false;
            // This sample will collect 1000 gaze points
             for(int i=0; i < 1400 && !_stopTracking; i++)
            {
                
                await Task.Run(() => {
                    //System.Threading.Thread.Sleep(100);
                    //Console.WriteLine(i);

                    // Optionally block this thread until data is available. Especially useful if running in a separate thread.
                    result = Interop.tobii_wait_for_callbacks(new[] { deviceContext });
                    Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR || result == tobii_error_t.TOBII_ERROR_TIMED_OUT);

                    // Process callbacks on this thread if data is available
                    result = Interop.tobii_device_process_callbacks(deviceContext);
                    Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
                    lblGazeDir.Update();


                } );
                
            }

          

           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //tobii
            // Create API context
            
            result = Interop.tobii_api_create(out apiContext, null); // tobii_api_create: Initializes the stream engine API, with optionally provided custom memory allocation and logging functions.
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            // Enumerate devices to find connected eye trackers
            List<string> urls;
            result = Interop.tobii_enumerate_local_device_urls(apiContext, out urls);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            if (urls.Count == 0)
            {
                Console.WriteLine("Error: No device found");
                return;
            }

            // Connect to the first tracker found
            string licensePath = @"C:\masterproef\code\eyetracker_startup\eyetracker_startup\tobii\se_license_key";
            /*IntPtr deviceContext;*/
            deviceContext = CreateTrackerWithLicense(apiContext, urls[0], licensePath);
            //result = Interop.tobii_device_create(apiContext, urls[0], Interop.tobii_field_of_use_t.TOBII_FIELD_OF_USE_STORE_OR_TRANSFER_FALSE, out deviceContext);
            //result = Interop.tobii_device_create_ex(apiContext, urls[0], Interop.tobii_field_of_use_t.TOBII_FIELD_OF_USE_STORE_OR_TRANSFER_FALSE, out deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            // Subscribe to gaze data
            result = Interop.tobii_gaze_point_subscribe(deviceContext, OnGazePoint);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            // get geometry mounting
            tobii_geometry_mounting_t geometry;
            result = Interop.tobii_get_geometry_mounting(deviceContext, out geometry);
            Console.WriteLine("GEOMETRY MOUNTING: | GUIDES: " + geometry.guides + " | WIDTH: " + geometry.width_mm + "mm | ANGLE: " + geometry.angle_deg + " degrees | " +
                "\nGEOMETRY MOUNTING: | EXTERNAL OFFSET (" + geometry.external_offset_mm_xyz.x + "," + geometry.external_offset_mm_xyz.y + "," + geometry.external_offset_mm_xyz.z +
                ")\nGEOMETRY MOUNTING: | INTERAL OFFSET (" + geometry.internal_offset_mm_xyz.x + "," + geometry.internal_offset_mm_xyz.y + "," + geometry.internal_offset_mm_xyz.z + ")");
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);


            // get display area
            tobii_display_area_t displayArea;

            result = Interop.tobii_get_display_area(deviceContext, out displayArea);
            Console.WriteLine("DISPLAY AREA: | top left: (" + displayArea.top_left_mm_xyz.x + "," + displayArea.top_left_mm_xyz.y + "," + displayArea.top_left_mm_xyz.z + ")");
            Console.WriteLine("DISPLAY AREA: | top right: (" + displayArea.top_right_mm_xyz.x + "," + displayArea.top_right_mm_xyz.y + "," + displayArea.top_right_mm_xyz.z + ")");
            Console.WriteLine("DISPLAY AREA: | bottem left: (" + displayArea.bottom_left_mm_xyz.x + "," + displayArea.bottom_left_mm_xyz.y + "," + displayArea.bottom_left_mm_xyz.z + ")");

            //calcualte display area
            float width_mm = (float)345.0;
            float height_mm = (float)194.0;
            float offset_x_mm = (float)0.0; //112.0

            //tobii_license_key_t


            result = Interop.tobii_calculate_display_area_basic(deviceContext, width_mm, height_mm, offset_x_mm, ref geometry, out displayArea);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("DISPLAY AREA: | top left: (" + displayArea.top_left_mm_xyz.x + "," + displayArea.top_left_mm_xyz.y + "," + displayArea.top_left_mm_xyz.z + ")");
            Console.WriteLine("DISPLAY AREA: | top right: (" + displayArea.top_right_mm_xyz.x + "," + displayArea.top_right_mm_xyz.y + "," + displayArea.top_right_mm_xyz.z + ")");
            Console.WriteLine("DISPLAY AREA: | bottem left: (" + displayArea.bottom_left_mm_xyz.x + "," + displayArea.bottom_left_mm_xyz.y + "," + displayArea.bottom_left_mm_xyz.z + ")");

            result = Interop.tobii_set_display_area(deviceContext, ref displayArea);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

            _stopTracking = true;
            // Cleanup
            result = Interop.tobii_gaze_point_unsubscribe(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            result = Interop.tobii_device_destroy(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            result = Interop.tobii_api_destroy(apiContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
        }
    }
}
