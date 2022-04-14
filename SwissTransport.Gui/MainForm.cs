#pragma warning disable CS8602

using SwissTransport.Core;
using SwissTransport.Models;
using System.Diagnostics;

namespace SwissTransport.Gui
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public ITransport transport;
        private Queue<Station> autocompleteStationsBuffer;

        public MainForm()
        {
            InitializeComponent();

            transport = new Transport();
            autocompleteStationsBuffer = new Queue<Station>();
        }

        private void FindConnections(object sender, EventArgs e)
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

                List<Station> stations = transport.GetStations(stationFinderStationInput.Text).StationList;

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

        private void AutoCompleteComboBoxKeyUp(object sender, KeyEventArgs e)
        {
            Util.AutocompletionHandler((ComboBox)sender, e, transport);
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

                foreach (Station station in stations)
                {
                    stationFinderStationList.Items.Add(station.Name);
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

                // generating google maps uri
                string uri = $"https://www.google.com/maps/search/?api=1&query=" +
                    $"{station.Coordinate.XCoordinate.ToString().Replace(",", ".")}," +
                    $"{station.Coordinate.YCoordinate.ToString().Replace(",", ".")}";

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                Process.Start(psi);
            }
            catch
            {
                Util.ShowError("Station Location Viewer", "Error while trying to show Station Location in Browser");
            }
        }

        private void TakeMeHome(object sender, EventArgs e)
        {
            if (File.Exists(Util.DATFILE))
            {
                connectionFinderFromInput.Text = transport.GetNearestStations().StationList[0].Name;
                connectionFinderToInput.Text = File.ReadAllLines(Util.DATFILE)[0];

                FindConnections(sender, e);
            }
            else
            {
                MessageBox.Show("You currently have no home stop set. You can set one now.", "Take Me Home");
                TakeMeHomeSettings(sender, e);
            }
        }

        private void TakeMeHomeSettings(object sender, EventArgs e)
        {
            TakeMeHomeSettingsForm takeMeHomeForm = new TakeMeHomeSettingsForm();
            takeMeHomeForm.Show();
        }
    }
}