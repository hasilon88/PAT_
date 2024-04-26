namespace PAT.Views
{
    public partial class FicheDemandeTuto 
    {
        public FicheDemandeTuto()
        {
            InitializeComponent();
        }
        private void OnEnvoyerClicked(object sender, EventArgs e) { 
 
            // Ici, ajoutez votre logique pour traiter la demande de rendez-vous
            // Par exemple, afficher un message de confirmation
            // TODO: removed this line since error
            // await DisplayAlert("Demande envoyée", $"Votre demande pour le {Microsoft.Maui.Controls.DatePicker.Date:D} a été envoyée.\nCommentaires: {EditorCommentaires.Text}", "OK");
        }
    }
}