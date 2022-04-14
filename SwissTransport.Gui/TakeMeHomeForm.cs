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

            try
            {
                homeStopInput.Text = File.ReadAllLines(Util.DATFILE)[0];
            }
            catch { }
        }

        private void SaveHomeStop(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(Util.DATFILE, homeStopInput.Text);
                this.Close();
            }
            catch 
            {
                Util.ShowError("Saving Home Stop", "Error while trying to write home stop to file");
            }
        }

        private void HomeStopInputKeyUp(object sender, KeyEventArgs e)
        {
            Util.AutocompletionHandler((ComboBox)sender, e, transport);
        }
    }
}