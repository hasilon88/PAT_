using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAT.Views;

public partial class TeacherRef : ContentPage
{
    public TeacherRef()
    {
        InitializeComponent();
    }
    private void OnEnvoyerClicked(object sender, EventArgs e) { 
 
        // Retrieving the comment
        string firstName = firstNameEntry.Text;
        string lastName = lastNameEntry.Text;

        
        // Now you can use these variables as needed. This example just displays them.
        
        DisplayAlert("Information envoyée", 
            $"Prénom: {firstName}\n" +
            $"Nom: {lastName}\n" +
            "",
            "OK");
    }
    
    private void OnEnvoyerClicked1(object sender, EventArgs e) { 
 
        // Retrieving the comment
        string firstName = firstNameEntry2.Text;
        string lastName = lastNameEntry2.Text;

        
        // Now you can use these variables as needed. This example just displays them.
        
        DisplayAlert("Information envoyée", 
            $"Prénom: {firstName}\n" +
            $"Nom: {lastName}\n" +
            "",
            "OK");
    }
}