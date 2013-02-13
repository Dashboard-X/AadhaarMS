using System;
using System.Collections.Generic;

using System.Text;

namespace Aadhaar
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;

    /// <summary>
    /// Utilities for use with Aadhaar.Data and Aadhaar.Web
    /// </summary>
    public static class Utilities
    {
        private static Object LockTxtLog = new Object();

        /// <summary>
        /// String display for messages with time difference from the current DateTime
        /// e.g.  "1hrs 20min ago"
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GetDateTimeForDisplay(DateTime? date)
        {
            if (date == null)
                return string.Empty;
            else
            {
                TimeSpan diff = DateTime.Now - date.Value;

                if (diff.TotalDays < 1)
                    return diff.Hours.ToString() + "hrs " + diff.Minutes.ToString() + "min ago";
                else
                    return date.Value.ToShortDateString() + " " + date.Value.ToShortTimeString();
            }
        }

        /// <summary>
        /// Format DateTime value for easy insertion into Database.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// For parsing DateTime string from the format "yyyyMMdd"
        /// </summary>
        /// <param name="dtString">DateTime string in "yyyyMMdd" format</param>
        /// <returns></returns>
        public static DateTime ParseDate(string dtString)
        {
            return DateTime.ParseExact(dtString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
        }


        /// <summary>
        /// If the current exception is just a wrapper for InnerException, clips the Wrapper exception to 50 characters
        /// If InnerException is not null. Clip the current exception to 50 characters.  
        /// E.g. "Current exception Message...{upto 50characters} + "...->" + InnerException.Message
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string FormatException(Exception ex)
        {
            string message = ex.Message;

            //Add the inner exception if present (showing only the first 50 characters of the first exception)
            if (ex.InnerException != null)
            {
                if (message.Length > 50)
                    message = message.Substring(0, 50);

                message += "...->" + ex.InnerException.Message;
            }

            return message;
        }

        
        /// <summary>
        /// Write message to Text log file
        /// The log file is maintained in the "logs/log.txt" document in the root directory of the application.
        /// </summary>
        /// <param name="Message"></param>
        public static void TextLog(string Message)
        {
            lock (LockTxtLog)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(NavHelper.GetPhysicalLocation("logs/log.txt"), true))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + Message);
                }


            }
        }

        
    }

}
