using PAT.Views;

namespace PAT;

public partial class App : Application
{
    public App(AvailabilityView mainPage)
    {
        InitializeComponent();

        MainPage = mainPage;
    }
}
