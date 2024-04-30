using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;


namespace PAT.Views
{
    public partial class MonCompte : ContentPage
    {
        User _user;
        
        public MonCompte(User user)
        {
            InitializeComponent();
            _user = user;

            NameEntry.Text = "Bonjour " + _user.FirstName + " " +  _user.LastName;
        }
        
        private async void OnDemandeInformations(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Informations());
        }
    
        private async void OnDemandeAgenda(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgendaPage());
        }
        private async void OnDemandeMesTutorat(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MesServicesTutoratPage());
        }
    }
}