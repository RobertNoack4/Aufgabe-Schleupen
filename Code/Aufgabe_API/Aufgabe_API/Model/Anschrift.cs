using System.ComponentModel.DataAnnotations;

namespace Aufgabe_API.Model
{
    public class Anschrift
    {
        [Key]
        public int AnschriftID { get; set; }

        public string Postleitzahl { get; set; }

        public string Ort { get; set; }

        public string Straße { get; set; }

        public string Hausnummer { get; set; }

        public int PersonID { get; set; }
    }
}
