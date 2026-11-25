using Aufgabe_DTO.Person;
using Aufgabe_WinForm.Controller;
using Aufgabe_WinForm.Controller.View_Controller;
using Aufgabe_WinForm.Services;

namespace Aufgabe_WinForm
{
    public partial class Overview : Form
    {
        private readonly OverviewController _controller;

        internal Overview(OverviewController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _controller.GetPersonenAsync();
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
            dataGridView1.DataSource = await _controller.GetPersonenByNameAsync(textBox1.Text);
        }
    }
}
