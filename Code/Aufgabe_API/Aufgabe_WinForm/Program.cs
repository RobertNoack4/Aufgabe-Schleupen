using Aufgabe_WinForm.Controller;
using Aufgabe_WinForm.Controller.API_Controller;
using Aufgabe_WinForm.Controller.View_Controller;
using Aufgabe_WinForm.Services;

namespace Aufgabe_WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var personenAPI = new PersonenAPIController(new PersonenService());
            var anschriftenAPI = new AnschriftenAPIController(new AnschriftenService());
            var telefonAPI = new TelefonverbindungAPIController(new TelefonverbindungsService());
            var overviewController = new OverviewViewController(personenAPI, anschriftenAPI,telefonAPI);

            var overview = new Overview(overviewController);

            Application.Run(overview);
        }
    }
}