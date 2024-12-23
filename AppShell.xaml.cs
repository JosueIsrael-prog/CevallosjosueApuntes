using CevallosjosueApuntes.Views; 

namespace CevallosjosueApuntes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

           
            Routing.RegisterRoute(nameof(NotePage), typeof(NotePage));
        }
    }
}
