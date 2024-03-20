using System.Diagnostics;
using PAT.Models.Entities;
using PAT.Models.Repositories;

namespace PAT;

public partial class MainPage : ContentPage
{
    private readonly IMessageRepository _messageRepository;

    public MainPage(IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
        InitializeComponent();

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadData();
    }

    
    private async Task LoadData()
    {
        try
        {
            await _messageRepository.CreateAsync(new Message() { Content = "Hello", SenderId = 1, ReceiverId = 2 });

            var messages = await _messageRepository.GetAllAsync();
            Messages.ItemsSource = messages;
        }
        catch (Exception ex)
        {
            // Log the exception or display an alert
            Debug.WriteLine($"An error occurred: {ex.Message}");
        }
    }

}