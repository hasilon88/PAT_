using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesCindy;

public partial class FicheDemandeTuto : ContentPage
{
    public FicheDemandeTuto()
    {
        InitializeComponent();
    }
    private async void OnEnvoyerClicked(object sender, EventArgs e)
    {
        // Ici, ajoutez votre logique pour traiter la demande de rendez-vous
        // Par exemple, afficher un message de confirmation
        await DisplayAlert("Demande envoyée", $"Votre demande pour le {datePicker.Date.ToString("D")} a été envoyée.\nCommentaires: {editorCommentaires.Text}", "OK");
    }
}