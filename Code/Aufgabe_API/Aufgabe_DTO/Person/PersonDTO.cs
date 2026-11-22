using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_DTO.Person
{
    public class PersonDTO
    {
        public int PersonID { get; set; }

        public string Name { get; set; }

        public string Vorname { get; set; }

        public DateOnly Geburtsdatum { get; set; }

        public string Name_Groß { get; set; }
    }
}
