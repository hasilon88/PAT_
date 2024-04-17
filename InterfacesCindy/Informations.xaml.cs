using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesCindy;

public partial class Informations : ContentPage
{
    public Informations()
    {
        InitializeComponent();
    }
    private async void OnDemandeHome(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}