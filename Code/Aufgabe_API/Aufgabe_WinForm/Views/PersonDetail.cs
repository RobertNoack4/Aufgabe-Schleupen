using Aufgabe_DTO.Anschrift;
using Aufgabe_DTO.Person;
using Aufgabe_DTO.TelefonVerbindung;
using Aufgabe_WinForm.Controller.View_Controller;

namespace Aufgabe_WinForm
{
    public partial class PersonDetail : Form
    {
        private readonly PersonDetailViewController _controller;
        private PersonCompleteDTO _personDTO;

        internal PersonDetail(PersonDetailViewController controller)
        {
            _controller = controller;
            InitializeComponent();
            LoadDataFromAPI();
        }

        private async void LoadDataFromAPI()
        {
            await LoadPersonDataFromAPI();
            await LoadAnschriftenDataFromAPI();
            await LoadTelefonverbindungenDataFromAPI();
        }

        private async Task LoadPersonDataFromAPI()
        {
            _personDTO = await _controller.GetPersonByIdAsync();

            if (_personDTO != null)
            {
                PersonDataGrid.DataSource = new[] { _personDTO };
            }
        }

        private async Task LoadAnschriftenDataFromAPI()
        {
            AnschriftenDataGrid.DataSource = await _controller.GetAnschriftenByPersonIDAsync();
            if(!AnschriftenDataGrid.Columns.Contains("DeleteButton"))
            {
                AnschriftenDataGrid.Columns.Add(CreateButtonColumn());
            }
        }

        private async Task LoadTelefonverbindungenDataFromAPI()
        {
            TelefonDataGrid.DataSource = await _controller.GetTelefonverbindungByPersonIDAsync();
            if(!TelefonDataGrid.Columns.Contains("DeleteButton"))
            {
                TelefonDataGrid.Columns.Add(CreateButtonColumn());
            }
        }

        private DataGridViewButtonColumn CreateButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            return buttonColumn;
        }

        private void nameChangeBtn_Click(object sender, EventArgs e)
        {
            _controller.OpenChangeNameView(_personDTO);
            LoadDataFromAPI();
        }

        private void createAnschriftBtn_Click(object sender, EventArgs e)
        {
            _controller.OpenCreateAnschriftView();
            LoadDataFromAPI();
        }

        private void createTelefonverbindungBtn_Click(object sender, EventArgs e)
        {
            _controller.OpenCreateTelefonverbindungView();
            LoadDataFromAPI();
        }

        private async void AnschriftenDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                AnschriftenDataGrid.Columns[e.ColumnIndex].Name == "DeleteButton")

            {
                var anschrift = AnschriftenDataGrid.Rows[e.RowIndex].DataBoundItem as AnschriftDTO;

                if (anschrift != null)
                {
                    await _controller.DeleteAnschriftAsync(anschrift.AnschriftID);
                    LoadDataFromAPI();
                }
            }
        }

        private async void TelefonDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                TelefonDataGrid.Columns[e.ColumnIndex].Name == "DeleteButton")

            {
                var telefonverbindung = TelefonDataGrid.Rows[e.RowIndex].DataBoundItem as TelefonverbindungDTO;

                if (telefonverbindung != null)
                {
                    await _controller.DeleteTelefonverbindungAsync(telefonverbindung.TelefonverbindungsID);
                    LoadDataFromAPI();
                }
            }
        }
    }
}
