using SwissTransport.Core;
using SwissTransport.Models;

namespace Gui
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

        private void viewConnections(object sender, EventArgs e)
        {
            connectionsFinderConnectionsTable.Rows.Clear();
            DateTime date = DateTime.Now;

            if (connectionFinderCustomDateCheck.Checked)
            {
                date = connectionFinderDatePicker.Value;
            }

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

        private void viewDepartureBoard(object sender, EventArgs e) 
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

        private void findStation(object sender, EventArgs e)
        {
            stationFinderStationList.Items.Clear();

            List<Station> stations = transport.GetStations(stationFinderStationTextBox.Text).StationList;

            foreach (Station station in stations)
            {
                stationFinderStationList.Items.Add(station.Name);
            }
        }

        private void stationFinderSelectFrom(object sender, EventArgs e)
        {
            string stationName = stationFinderStationList.GetItemText(stationFinderStationList.SelectedItem);
            connectionFinderFromInput.Text = stationName;
            departureBoardStationSearchTextBox.Text = stationName;

            connectionFinderFromInput.Focus();
            applicationTabControl.SelectedIndex = 2;
        }

        private void stationFinderSelectTo(object sender, EventArgs e)
        {
            connectionFinderToInput.Text = stationFinderStationList.GetItemText(stationFinderStationList.SelectedItem);

            connectionFinderToInput.Focus();
            applicationTabControl.SelectedIndex = 2;
        }

        private void connectionFinderFromInputKeyUp(object sender, KeyEventArgs e)
        {
            // don't autocomplete: until 2 characters are entered, and other filters
            if (connectionFinderFromInput.Text.Length <= 1
                || e.KeyCode == Keys.Enter
                || Char.IsControl((char)e.KeyCode)) 
            {
                return;
            } 

            //connectionFinderFromInput.Items.Clear();

            // accumulate stations if key pressed wasn't a control character
            foreach (Station station in transport.GetStations(connectionFinderFromInput.Text).StationList)
            {
                connectionFinderFromInput.Items.Add(station.Name);
            }
        }

        private void connectionFinderToInputKeyUp(object sender, KeyEventArgs e)
        {
            // don't autocomplete: until 2 characters are entered, and other filters
            if (connectionFinderToInput.Text.Length <= 1
                || e.KeyCode == Keys.Enter
                || Char.IsControl((char)e.KeyCode))
            {
                return;
            }

            //connectionFinderFromInput.Items.Clear();

            // accumulate stations if key pressed wasn't a control character
            foreach (Station station in transport.GetStations(connectionFinderToInput.Text).StationList)
            {
                connectionFinderToInput.Items.Add(station.Name);
            }
        }

        private void connectionFinderCustomDateCheckCheckedChanged(object sender, EventArgs e)
        {
            connectionFinderDatePicker.Enabled = connectionFinderCustomDateCheck.Checked;
        }
    }
}