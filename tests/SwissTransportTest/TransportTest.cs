namespace SwissTransport
{
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void NearestLocations()
        {
            Stations stations = this.testee.GetNearestStations();

            stations.StationList.Should().NotBeNull();
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern");
            Connections connectionsCustomTime = this.testee.GetConnections("Sursee", "Luzern", System.DateTime.Now);

            connections.Should().NotBeNull();
            connectionsCustomTime.Should().NotBeNull();
        }
    }
}