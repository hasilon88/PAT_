using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesCindy;


namespace InterfacesCindy;

public partial class MesServicesTutoratPage : ContentPage
{
    public MesServicesTutoratPage()
    {
        InitializeComponent();
    }
    
    private async void NaviguerVersAgenda(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AgendaPage());
    }

}