using System.Collections.ObjectModel;
using CevallosjosueApuntes.Models;

namespace CevallosjosueApuntes.ViewModels;

public class NotesViewModel                                                                                            
{
    public ObservableCollection<Note> Notes { get; set; }

    public NotesViewModel()
    {
        Notes = new ObservableCollection<Note>();
    }
}
                                                               