namespace PAT.Views
{
    public partial class MesServicesTutoratPage 
    {
        public MesServicesTutoratPage()
        {
            InitializeComponent();
        }
    
        private async void NaviguerVersAgenda(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgendaPage());
        }

    }
}