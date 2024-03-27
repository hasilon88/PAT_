using PAT.Models.Entities;
using PAT.Models.Repositories;

namespace PAT;

public partial class AddUser : ContentPage
{
    private readonly IUserRepository _userRepository;

    public AddUser(IUserRepository userRepository)
    {
        InitializeComponent();
        _userRepository = userRepository;
    }
    
    private async void OnAddUserClicked(object sender, EventArgs e)
    {
        var firstName = FirstNameEntry.Text;
        var lastName = LastNameEntry.Text;
        var email = EmailEntry.Text;
        var number = NumberEntry.Text;

        if (string.IsNullOrWhiteSpace(firstName) || 
            string.IsNullOrWhiteSpace(lastName) || 
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(number))
        {
            await DisplayAlert("Validation Failed", "Please enter all fields.", "OK");
            return;
        }

        User user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Phone = number
        };

        await _userRepository.CreateAsync(user); 
        
        await DisplayAlert("Success", "User added successfully", "OK");
        
        await Navigation.PopModalAsync();
    }
    
    private async void Cancel(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}