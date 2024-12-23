using System.Collections.ObjectModel;
using System.IO;

namespace CevallosjosueApuntes.Models
{
    public class AllNotes
    {
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        public AllNotes() => LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();
            string appDataPath = FileSystem.AppDataDirectory;
            var notes = Directory
                        .EnumerateFiles(appDataPath, "*.notes.txt")
                        .Select(filename => new Note
                        {
                            Filename = filename,
                            Text = File.ReadAllText(filename),
                            Date = File.GetLastWriteTime(filename)
                        })
                        .OrderBy(note => note.Date);

            foreach (var note in notes)
                Notes.Add(note);
        }
    }
}
