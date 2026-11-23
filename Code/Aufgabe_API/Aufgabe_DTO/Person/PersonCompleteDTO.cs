namespace Aufgabe_DTO.Person
{
    public class PersonCompleteDTO
    {
        public int PersonID { get; set; }

        public string Name { get; set; }

        public string Vorname { get; set; }

        public DateOnly Geburtsdatum { get; set; }

        public string Name_Groß { get; set; }
    }
}
