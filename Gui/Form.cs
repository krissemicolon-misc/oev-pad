using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGui
{
    public partial class Form : System.Windows.Forms.Form
    {
        public ITransport transport;
        private Queue<Station> autocompleteStationsBuffer;

        public Form()
        {
            InitializeComponent();

            transport = new Transport();
            autocompleteStationsBuffer = new Queue<Station>();
        }

        private void ViewConnections(object sender, EventArgs e)
        {
            try
            {
                connectionsFinderConnectionsTable.Rows.Clear();

                DateTime date = connectionFinderCustomDateCheck.Checked
                    ? connectionFinderDatePicker.Value
                    : DateTime.Now;

                List<Connection> connections = transport.GetConnections(
                    connectionFinderFromInput.Text,
                    connectionFinderToInput.Text,
                    date
                ).ConnectionList;

                foreach (Connection connection in connections)
                {
                    connectionsFinderConnectionsTable.Rows.Add(
                        connection.From.Station.Name,
                        connection.To.Station.Name,
                        connection.From.Departure,
                        connection.To.Arrival,
                        connection.Duration
                    );
                }
            }
            catch
            {
                Util.ShowError("Connections Viewer", "Error viewing connections");
            }

        }

        private void ViewDepartureBoard(object sender, EventArgs e)
        {
            try
            {
                departureBoardTable.Rows.Clear();

                List<StationBoard> stationBoards = transport.GetStationBoard(departureBoardStationSearchTextBox.Text, "1").Entries;

                foreach (StationBoard stationBoard in stationBoards)
                {
                    departureBoardTable.Rows.Add(
                        stationBoard.Name,
                        stationBoard.Category,
                        stationBoard.Number,
                        stationBoard.To,
                        stationBoard.Operator,
                        stationBoard.Stop.Departure
                    );
                }
            }
            catch
            {
                Util.ShowError("Departure-Board Viewer", "Error viewing departures");
            }
        }

        private void FindStation(object sender, EventArgs e)
        {
            try
            {
                stationFinderStationList.Items.Clear();

                List<Station> stations = transport.GetStations(stationFinderStationTextBox.Text).StationList;

                foreach (Station station in stations)
                {
                    stationFinderStationList.Items.Add(station.Name);
                }
            }
            catch
            {
                Util.ShowError("Station Finder", "Error while finding Stations");
            }
        }

        private void StationFinderSelectFrom(object sender, EventArgs e)
        {
            try
            {
                string stationName = stationFinderStationList.GetItemText(stationFinderStationList.SelectedItem);
                connectionFinderFromInput.Text = stationName;
                departureBoardStationSearchTextBox.Text = stationName;

                connectionFinderFromInput.Focus();
                applicationTabControl.SelectedIndex = 2;
            }
            catch
            {
                Util.ShowError("Station Finder", "Error while trying to use Station as Departure");
            }
        }

        private void StationFinderSelectTo(object sender, EventArgs e)
        {
            try
            {
                connectionFinderToInput.Text = stationFinderStationList.GetItemText(stationFinderStationList.SelectedItem);

                connectionFinderToInput.Focus();
                applicationTabControl.SelectedIndex = 2;
            }
            catch
            {
                Util.ShowError("Station Finder", "Error while trying to use Station as Destination");
            }
        }

        private void ConnectionFinderFromInputKeyUp(object sender, KeyEventArgs e)
        {
            AutocompletionHandler((ComboBox)sender, e);
        }

        private void ConnectionFinderToInputKeyUp(object sender, KeyEventArgs e)
        {
            AutocompletionHandler((ComboBox)sender, e);
        }

        private void AutocompletionHandler(ComboBox comboBox, KeyEventArgs e)
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
            {}
        }

        private void ConnectionFinderCustomDateCheckCheckedChanged(object sender, EventArgs e)
        {
            connectionFinderDatePicker.Enabled = connectionFinderCustomDateCheck.Checked;
        }

        private void ShareConnectionOverEmail(object sender, EventArgs e)
        {
            try
            {
                string connectionInfo = Util.GridViewStringify(connectionsFinderConnectionsTable.SelectedRows[0]);

                Util.EmailPopup("", "SwissTransport-Connection", connectionInfo);
            }
            catch
            {
                Util.ShowError("Email Share", "Error while sharing connection via email");
            }
        }

        private void StationFinderFindNearestStation(object sender, EventArgs e)
        {
            try
            {
                stationFinderStationList.Items.Clear();

                List<Station> stations = transport.GetNearestStations().StationList;

                for (int i = stations.Count - 1; i >= 0; --i)
                {
                    stationFinderStationList.Items.Add(stations[i].Name);
                }
            }
            catch
            {
                Util.ShowError("Nearest Station Finder", "Error while trying to fetch nearest stations");
            }
        }

        private void ShowStationLocationInBrowser(object sender, EventArgs e)
        {
            try
            {
                Station station = transport.GetStations(stationFinderStationList.GetItemText(stationFinderStationList.SelectedItem)).StationList[0];
                System.Diagnostics.Process.Start($"https://www.openstreetmap.org/?mlat={station.Coordinate.XCoordinate}&mlon={station.Coordinate.YCoordinate}");
            }
            catch
            {
                Util.ShowError("Station Location Viewer", "Error while trying to show Station Location in Browser");
            }
        }

        private void TakeMeHome(object sender, EventArgs e)
        {
         //   TakeMeHomeForm takeMeHomeForm = new TakeMeHomeForm();
          //  takeMeHomeForm.Show();
        }
    }
}