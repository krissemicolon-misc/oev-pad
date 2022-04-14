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
using SwissTransport.Models;
using SwissTransport.Core;

namespace SwissTransport.Gui
{
    public class Util
    {
        public static string DATFILE = Path.GetTempPath() + "oev-pad.dat";

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

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = @"mailto:" + emailAddress + "?subject=" + subject + "&body=" + body;
            Process.Start(psi);
        }

        public static void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void AutocompletionHandler(ComboBox comboBox, KeyEventArgs e, ITransport transport)
        {
            try
            {
                // don't autocomplete: until 2 characters are entered, and other filters
                if (comboBox.Text.Length <= 1
                    || e.KeyCode == Keys.Enter
                    || Char.IsControl((char)e.KeyCode))
                {
                    return;
                }

                //connectionFinderFromInput.Items.Clear();

                // accumulate stations
                foreach (Station station in transport.GetStations(comboBox.Text).StationList)
                {
                    comboBox.Items.Add(station.Name);
                }

                comboBox.SelectionStart = comboBox.Text.Length;
            }
            catch
            { }
        }
    }
}
