using System;
using System.Collections.Generic;
using System.Text;

using Tobii.StreamEngine;
using System.IO;
using System.Diagnostics;

namespace Calibration
{
    public class TobiiTracker
    {
        public static float coordinaat_x;
        public static float coordinaat_y;
        public static long timestamp;

        private static tobii_gaze_point_callback_t newOnGazePoint = new tobii_gaze_point_callback_t(OnGazePoint);
        private static tobii_notifications_callback_t newNotificationCallCallback = new tobii_notifications_callback_t(NotificationCallCallback);

        private static void OnGazePoint(ref tobii_gaze_point_t gazePoint, IntPtr userData)
        {
            // Check that the data is valid before using it
            if (gazePoint.validity == tobii_validity_t.TOBII_VALIDITY_VALID)
            {
                coordinaat_x = gazePoint.position.x;
                coordinaat_y = gazePoint.position.y;
                timestamp = gazePoint.timestamp_us;
            }
        }

        private static void NotificationCallCallback(ref tobii_notification_t notification, IntPtr userData)
        {
            if (notification.type == tobii_notification_type_t.TOBII_NOTIFICATION_TYPE_CALIBRATION_STATE_CHANGED)
            {
                if (notification.value.state == tobii_state_bool_t.TOBII_STATE_BOOL_TRUE)
                {
                    Console.WriteLine("calibration started\n");
                }
                else
                {
                    Console.WriteLine("calibration stopped\n");
                }
            }
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

        public static void record(IntPtr deviceContext)
        {
            //tobii_error_t result;

            //while (true){
            // Optionally block this thread until data is available. Especially useful if running in a separate thread.
            Interop.tobii_wait_for_callbacks(new[] { deviceContext });
            //Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR || result == tobii_error_t.TOBII_ERROR_TIMED_OUT);

            // Process callbacks on this thread if data is available
            Interop.tobii_device_process_callbacks(deviceContext);
            //Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            //}
        }

        public static Tuple<IntPtr, IntPtr> subscribe()
        {
            // Create API context
            IntPtr apiContext;
            tobii_error_t result = Interop.tobii_api_create(out apiContext, null); // tobii_api_create: Initializes the stream engine API, with optionally provided custom memory allocation and logging functions.
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            // Enumerate devices to find connected eye trackers
            List<string> urls;
            result = Interop.tobii_enumerate_local_device_urls(apiContext, out urls);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            if (urls.Count == 0)
            {
                Console.WriteLine("Error: No device found");
                return null;
            }

            // path jonas:
            string licensePath = @"C:\Users\jonas\SynologyDrive\GIT\WORKING_WITH_YOUR_EYES\Calibration\tobii\se_license_key";
            // path jeroen:
            //string licensePath = @"C:\masterproef\code\instructionForm\instructionForm\tobii\se_license_key";
            IntPtr deviceContext;
            deviceContext = CreateTrackerWithLicense(apiContext, urls[0], licensePath);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            // Subscribe to gaze data
            result = Interop.tobii_gaze_point_subscribe(deviceContext, newOnGazePoint);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            // Subscribe to callibrate notification
            result = Interop.tobii_notifications_subscribe(deviceContext, newNotificationCallCallback);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);


            // Get geometry mounting
            tobii_geometry_mounting_t geometry;
            result = Interop.tobii_get_geometry_mounting(deviceContext, out geometry);
            Console.WriteLine("GEOMETRY MOUNTING: | GUIDES: " + geometry.guides + " | WIDTH: " + geometry.width_mm + "mm | ANGLE: " + geometry.angle_deg + " degrees | " +
                "\nGEOMETRY MOUNTING: | EXTERNAL OFFSET (" + geometry.external_offset_mm_xyz.x + "," + geometry.external_offset_mm_xyz.y + "," + geometry.external_offset_mm_xyz.z +
                ")\nGEOMETRY MOUNTING: | INTERAL OFFSET (" + geometry.internal_offset_mm_xyz.x + "," + geometry.internal_offset_mm_xyz.y + "," + geometry.internal_offset_mm_xyz.z + ")");
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);


            // Get display area
            tobii_display_area_t displayArea;
            result = Interop.tobii_get_display_area(deviceContext, out displayArea);
            Console.WriteLine("DISPLAY AREA: | top left: (" + displayArea.top_left_mm_xyz.x + "," + displayArea.top_left_mm_xyz.y + "," + displayArea.top_left_mm_xyz.z + ")");
            Console.WriteLine("DISPLAY AREA: | top right: (" + displayArea.top_right_mm_xyz.x + "," + displayArea.top_right_mm_xyz.y + "," + displayArea.top_right_mm_xyz.z + ")");
            Console.WriteLine("DISPLAY AREA: | bottem left: (" + displayArea.bottom_left_mm_xyz.x + "," + displayArea.bottom_left_mm_xyz.y + "," + displayArea.bottom_left_mm_xyz.z + ")");

            // Calcualte display area
            float width_mm = (float)365.0;
            float height_mm = (float)210.0;
            float offset_x_mm = (float)0.0;

            result = Interop.tobii_calculate_display_area_basic(deviceContext, width_mm, height_mm, offset_x_mm, ref geometry, out displayArea);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("DISPLAY AREA: | top left: (" + displayArea.top_left_mm_xyz.x + "," + displayArea.top_left_mm_xyz.y + "," + displayArea.top_left_mm_xyz.z + ")");
            Console.WriteLine("DISPLAY AREA: | top right: (" + displayArea.top_right_mm_xyz.x + "," + displayArea.top_right_mm_xyz.y + "," + displayArea.top_right_mm_xyz.z + ")");
            Console.WriteLine("DISPLAY AREA: | bottem left: (" + displayArea.bottom_left_mm_xyz.x + "," + displayArea.bottom_left_mm_xyz.y + "," + displayArea.bottom_left_mm_xyz.z + ")");

            // Set display area
            result = Interop.tobii_set_display_area(deviceContext, ref displayArea);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            return Tuple.Create(deviceContext, apiContext);
        }

        public static void unsubscribe(IntPtr deviceContext, IntPtr apiContext)
        {
            // Cleanup
            tobii_error_t result = Interop.tobii_gaze_point_unsubscribe(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            result = Interop.tobii_device_destroy(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
            result = Interop.tobii_api_destroy(apiContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
        }

        public static void calibrateFirst(IntPtr deviceContext, IntPtr apiContext)
        {
            tobii_error_t result = Interop.tobii_calibration_clear(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);


            result = Interop.tobii_calibration_start(deviceContext, tobii_enabled_eye_t.TOBII_ENABLED_EYE_BOTH);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            //tobii_error_t result = Interop.tobii_notifications_subscribe(deviceContext, );
            //Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);


            float cal_x = (float)0.5;
            float cal_y = (float)0.5;
            result = Interop.tobii_calibration_collect_data_2d(deviceContext, cal_x, cal_y);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            result = Interop.tobii_calibration_compute_and_apply(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            result = Interop.tobii_calibration_stop(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
        }

        public static void startPersonCal(IntPtr deviceContext)
        {
            tobii_error_t result = Interop.tobii_calibration_start(deviceContext, tobii_enabled_eye_t.TOBII_ENABLED_EYE_BOTH);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
        }

        public static void computeApplyStopPersonCal(IntPtr deviceContext)
        {
            tobii_error_t result = Interop.tobii_calibration_compute_and_apply(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);

            result = Interop.tobii_calibration_stop(deviceContext);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
        }

        public static void calcPnt(IntPtr deviceContext, double x, double y)
        {
            float cal_x = (float)x;
            float cal_y = (float)y;
            tobii_error_t result = Interop.tobii_calibration_collect_data_2d(deviceContext, cal_x, cal_y);
            Debug.Assert(result == tobii_error_t.TOBII_ERROR_NO_ERROR);
        }
    }
}
