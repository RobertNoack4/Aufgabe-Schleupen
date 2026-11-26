using Aufgabe_DTO.Person;
using Aufgabe_WinForm.Controller.View_Controller;

namespace Aufgabe_WinForm.Views
{
    public partial class ChangeName : Form
    {
        private readonly ChangeNameViewController _controller;

        internal ChangeName(ChangeNameViewController controller, PersonCompleteDTO personCompleteDTO)
        {
            _controller = controller;
            InitializeComponent();
            this.nameTxb.Text = personCompleteDTO.Name;
            this.vornameTxb.Text = personCompleteDTO.Vorname;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            var name = this.nameTxb.Text;
            var vorname = this.vornameTxb.Text;

            await _controller.UpdatePersonNameAsync(name, vorname);
            this.Close();
        }
    }
}
