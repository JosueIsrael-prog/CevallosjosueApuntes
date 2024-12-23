using CevallosjosueApuntes.Models;

namespace CevallosjosueApuntes.Views
{
    public partial class NotePage : ContentPage
    {
        public NotePage()
        {
            InitializeComponent();
        }

        public NotePage(Note note)
        {
            InitializeComponent();
            BindingContext = note;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (BindingContext is Note note)
            {
                string appDataPath = FileSystem.AppDataDirectory;
                string filename = Path.Combine(appDataPath, $"{Path.GetRandomFileName()}.notes.txt");

                File.WriteAllText(filename, note.Text);
                note.Filename = filename;

                await Shell.Current.GoToAsync("..");
            }
        }
    }
}
