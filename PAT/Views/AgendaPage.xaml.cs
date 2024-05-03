using PAT.Models.Entities;

namespace PAT.Views
{
    public partial class AgendaPage
    {
        private Availability _availability;
        Student _student;
        public AgendaPage(Student student)
        {
           InitializeComponent();
           
           _student = student;

           NameEntry.Text = "Bonjour " + _student.FirstName + " " +  _student.LastName;
         
        }
    }
}