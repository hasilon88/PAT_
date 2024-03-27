using System.Collections.ObjectModel;
using PAT.Models.Entities;
using PAT.Models.Repositories;

namespace PAT;

public partial class MainPage
{
    private readonly IUserRepository _userRepository;
    public ObservableCollection<User> Users { get; }
    
    public MainPage(IUserRepository userRepository)
    {
        InitializeComponent();
        _userRepository = userRepository;
        Users = new ObservableCollection<User>();
        BindingContext = this; 
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        Users.Clear();
        await LoadData();
    }

    
    private async Task LoadData()
    { 
        var users = await _userRepository.GetAllAsync();
        
        users = users.Where(u => !u.IsDeleted).Select(u => u);

        foreach (var user in users)
        {
            Users.Add(user);
        }
    }

    private async void AddUser(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddUser(_userRepository));  
        OnAppearing();
    }

    private async void DeleteUser(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is User user)
        {
            bool confirmation = await DisplayAlert("Delete User", $"Are you sure you want to delete {user.FirstName}?", "Yes", "No");

            if (confirmation)
            {
                await _userRepository.DeleteAsync((int) user.Id);
                Users.Remove(user);
            }
        }
    }

    private async void EditUser(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is User user)
        {
            await Navigation.PushModalAsync(new EditUser(_userRepository, user));    
        }
        
        await LoadData();
    }
}