using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransport.Gui
{
    public partial class TakeMeHomeSettingsForm : Form
    {
        private ITransport transport;

        public TakeMeHomeSettingsForm()
        {
            InitializeComponent();
            transport = new Transport();

            homeStopInput.Text = File.ReadAllLines(Util.DATFILE)[0];
        }

        private void SaveHomeStop(object sender, EventArgs e)
        {
            File.WriteAllText(Util.DATFILE, homeStopInput.Text);
            this.Close();
        }

        private void HomeStopInputKeyUp(object sender, KeyEventArgs e)
        {
            Util.AutocompletionHandler((ComboBox)sender, e, transport);
        }
    }
}