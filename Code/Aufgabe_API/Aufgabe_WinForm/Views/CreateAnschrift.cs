using Aufgabe_WinForm.Controller.View_Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aufgabe_WinForm.Views
{
    public partial class CreateAnschrift : Form
    {
        private readonly CreateAnschriftViewController _controller;

        internal CreateAnschrift(CreateAnschriftViewController controller)
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
            var postleitzahl = postleitzahlTxb.Text;
            var ort = ortTbx.Text;
            var strasse = strasseTbx.Text;
            var hausnummer = hausnummerTbx.Text;

            await _controller.CreateAnschriftAsync(postleitzahl, ort, strasse, hausnummer);
            this.Close();
        }
    }
}
