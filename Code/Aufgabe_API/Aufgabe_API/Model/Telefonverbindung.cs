using System.ComponentModel.DataAnnotations;

namespace Aufgabe_API.Model
{
    public class Telefonverbindung
    {
        [Key]
        public int TelefonverbindungsID { get; set; }

        public string Nummer { get; set; }

        public int PersonID { get; set; }
    }
}
