namespace PAT.Views
{
    public partial class TutoratDisopPage 
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
}