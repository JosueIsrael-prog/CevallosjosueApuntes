using CevallosjosueApuntes.Models;
using CevallosjosueApuntes.ViewModels;

namespace CevallosjosueApuntes.Views
{
    public partial class AllNotesPage : ContentPage
    {
        public AllNotesPage()
        {
            InitializeComponent();
            BindingContext = new NotesViewModel();
        }

        private async void OnAddNoteClicked(object sender, EventArgs e)
        {
            var newNote = new Note
            {
                Text = "Nueva Nota",
                Date = DateTime.Now
            };

            await Shell.Current.GoToAsync(nameof(NotePage), true, new Dictionary<string, object>
            {
                { "Note", newNote }
            });
        }
    }
}
