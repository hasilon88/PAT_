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

            firstName.Text = _student.FirstName;
            lastName.Text = _student.LastName;
            matricule.Text = _student.DANumber;
            email.Text = _student.Email;
        }

        /**
            private async void OnDemandeHome(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new MonCompte());
            }
        **/
    }
}