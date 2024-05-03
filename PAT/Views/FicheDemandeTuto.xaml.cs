using System;
using Microsoft.Maui.Controls;
using PAT.Models.Entities;
namespace PAT.Views
{

    
    public partial class FicheDemandeTuto : ContentPage
    {

        public FicheDemandeTuto()
        {
            InitializeComponent();


        }
        private void OnEnvoyerClicked(object sender, EventArgs e) { 
 
            // Retrieving the comment
            string comment = editorCommentaires.Text;

            // Retrieving the start date and time
            DateTime startDate = dispoStartDate.Date;
            TimeSpan startTime = dispoStartTime.Time;
            DateTime fullStartDateTime = startDate.Add(startTime);

            // Retrieving the end date and time
            DateTime endDate = dispoEndDate.Date;
            TimeSpan endTime = dispoEndTime.Time;
            DateTime fullEndDateTime = endDate.Add(endTime);

            // Now you can use these variables as needed. This example just displays them.
            DisplayAlert("Input Summary", 
                $"Comment: {comment}\n" +
                $"Start: {fullStartDateTime}\n" +
                $"End: {fullEndDateTime}", 
                "OK");
        }
    }
}