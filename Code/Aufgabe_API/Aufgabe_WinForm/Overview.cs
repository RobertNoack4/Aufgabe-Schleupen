using Aufgabe_DTO.Person;
using Aufgabe_WinForm.Controller;
using Aufgabe_WinForm.Services;

namespace Aufgabe_WinForm
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var personenList = await PersonenController.GetPersonen();
            dataGridView1.DataSource = personenList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is PersonPartialDTO person)
            {
                var test = person.Name;
            }
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            var personenList = await PersonenController.GetPersonenByNameAsync(textBox1.Text);
            dataGridView1.DataSource = personenList;
        }
    }
}
