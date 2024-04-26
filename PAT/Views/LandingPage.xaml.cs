using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Views
{
    public partial class LandingPage : ContentPage
    {
        private readonly IAdminRepository _adminRepository;
        Admin _admin;
        public LandingPage(IAdminRepository adminRepository, Admin admin)
        {
            _adminRepository = adminRepository;
            _admin = admin;
            InitializeComponent();
        }
    
        public async void OnDemandeTutoratClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TutoratDisopPage());
    }
    }
}