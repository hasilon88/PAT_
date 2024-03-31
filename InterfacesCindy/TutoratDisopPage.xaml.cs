using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesCindy;

public partial class TutoratDisopPage : ContentPage
{
    public TutoratDisopPage()
    {
        InitializeComponent();
    }
    private async void OnFicheDemandeTutorat(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FicheDemandeTuto());
    }
}