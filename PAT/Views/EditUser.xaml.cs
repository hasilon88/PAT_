using System;
using PAT.Models.Entities;
using PAT.Models.Repositories;

namespace PAT;

public partial class EditUser : ContentPage
{
    private readonly IUserRepository _userRepository;
    User _user;

    public EditUser(IUserRepository userRepository, User user)
    {
        InitializeComponent();
        _userRepository = userRepository;
        _user = user;
        
        FirstNameEntry.Text = _user.FirstName;
        LastNameEntry.Text = _user.LastName;
        EmailEntry.Text = _user.Email;
        NumberEntry.Text = _user.Phone;
    }
    
    private async void OnEditUserClicked(object sender, EventArgs e)
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

        await _userRepository.DeleteAsync((int) _user.Id);
        await _userRepository.CreateAsync(user);
        
        await DisplayAlert("Success", "User updated successfully", "OK");
        
        await Navigation.PopModalAsync();
    }

    private async void Cancel(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}