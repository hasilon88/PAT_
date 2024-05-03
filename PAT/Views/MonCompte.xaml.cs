using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;


namespace PAT.Views
{
    public partial class MonCompte : ContentPage
    {
        User _user;
        Student _student;
        
        public MonCompte(Student student)
        {
            InitializeComponent();
            _student = student;

            NameEntry.Text = "Bonjour " + _student.FirstName + " " +  _student.LastName;
        }
        
        private async void OnDemandeInformations(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Informations(_student));
        }
    
        private async void OnDemandeAgenda(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgendaPage(_student));
        }
        private async void OnDemandeMesTutorat(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MesServicesTutoratPage());
        }
    }
}