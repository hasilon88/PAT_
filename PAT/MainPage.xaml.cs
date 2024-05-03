using PAT.Models.Entities;
 using PAT.Models.Repositories;
 using PAT.Models.Repositories.Interfaces;
 using PAT.ViewModels;
 using PAT.Views;
 
 namespace PAT
 {
     public partial class MainPage
     {
         private readonly MainPageViewModel _viewModel;
         private readonly IAdminRepository _adminRepository;
 
         public MainPage(
             IAdminRepository adminRepository,
             IStudentRepository studentRepository,
             ITeacherRepository teacherRepository
         )
         {
             InitializeComponent();
             _adminRepository = adminRepository;
             _viewModel = new MainPageViewModel(
                 adminRepository,
                 studentRepository,
                 teacherRepository
             );
             BindingContext = _viewModel;
             LoadUsers();
         }
 
         private async Task LoadUsers()
         {
             await _viewModel.GetAllUsers();
         }
 
         
         private async void ChooseUser(object sender, EventArgs e)
         {
             if (sender is Button button)
             {
                 if (button.BindingContext is Student student)
                 {
                     await Navigation.PushAsync(new MonCompte(student));
                 }
             }
         }
     }
 }