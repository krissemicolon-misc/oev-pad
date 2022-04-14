using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace SwissTransportGui
{
    public class Util
    {
        public static string GridViewStringify(DataGridViewRow row) 
        {
            string result = "";

            for (int i = 0; i < row.Cells.Count; ++i) 
            {
                result += row.Cells[i].Value + " ";
            }

            return result;
        }

        public static void EmailPopup(string emailAddress, string subject, string body)
        {
            Process.Start(@"mailto:" + emailAddress + "?subject=" + subject + "&body=" + body);
        }

        public static void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
