using Aufgabe_WinForm.Controller.View_Controller;

namespace Aufgabe_WinForm.Views
{
    public partial class CreateTelefonverbindung : Form
    {
        private readonly CreateTelefonverbindungViewController _controller;

        internal CreateTelefonverbindung(CreateTelefonverbindungViewController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            var nummer = telefonverbindungTbx.Text;

            await _controller.CreateTelefonverbindungAsync(nummer);
            this.Close();
        }
    }
}
