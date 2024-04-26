using System.Diagnostics;
using PAT.Models.Entities;
using PAT.Models.Repositories;

namespace PAT;

public partial class MainPage
{
    private readonly IMessageRepository _messageRepository;
    private readonly IStudentRepository _studentRepository;
    
    public MainPage(IMessageRepository messageRepository, IStudentRepository studentRepository)
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
            await _messageRepository.CreateAsync(new Message() { Content = "Yes", SenderId = 2, ReceiverId = 1 });
            await _messageRepository.CreateAsync(new Message() { Content = "How Are You?", SenderId = 1, ReceiverId = 2 });
            await _messageRepository.CreateAsync(new Message() { Content = "Good and you?", SenderId = 2, ReceiverId = 1 });
            await _messageRepository.CreateAsync(new Message() { Content = "yuuup", SenderId = 1, ReceiverId = 2 });
            
            
            
            var messages = await _messageRepository.GetAllAsync();

            var list = messages.Where(m => m.ReceiverId == 1).ToList();
        }
        catch (Exception ex)
        {
            // Log the exception or display an alert
            Debug.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
