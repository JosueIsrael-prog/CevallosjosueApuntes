namespace CevallosjosueApuntes.Models
{
    public class Note
    {
        public string Filename { get; set; } = string.Empty; // Propiedad agregada
        public string Text { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
