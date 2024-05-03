using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PAT.Models.Repositories.Interfaces;
using System.Threading.Tasks;
using PAT.Models.Entities;

namespace PAT.Views
{
    public partial class Informations : ContentPage
    {
        Student _student;
        public Informations(Student student)
        {
            
            InitializeComponent();
            _student = student;

            NameEntry.Text = _student.FirstName;
            LastNameEntry.Text = _student.LastName;
            DAEntry.Text = _student.DANumber;
        }

        
            private async void OnDemandeHome(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new MonCompte(_student));
            }
        
    }
}