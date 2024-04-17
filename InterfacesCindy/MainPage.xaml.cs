namespace InterfacesCindy;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    private void OnCounterClicked(object sender, EventArgs e)
    {
    
    }
    
    private async void OnDemandeTutoratClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TutoratDisopPage());
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