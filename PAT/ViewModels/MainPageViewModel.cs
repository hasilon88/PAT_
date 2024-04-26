using System.Collections.ObjectModel;
using PAT.Models.Entities;
using PAT.Models.Repositories;
using PAT.Models.Repositories.Interfaces;

namespace PAT.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Admin> Admins { get; }
        public ObservableCollection<Student> Students { get; }
        public ObservableCollection<Teacher> Teachers { get; }
    
        private readonly IAdminRepository _adminRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ITeacherRepository _teacherRepository;
    
        public MainPageViewModel(
            IAdminRepository adminRepository,
            IStudentRepository studentRepository,
            ITeacherRepository teacherRepository 
        )
    {
        _adminRepository = adminRepository;
        _studentRepository = studentRepository;
        _teacherRepository = teacherRepository;

        Admins = new ObservableCollection<Admin>();
        Students = new ObservableCollection<Student>();
        Teachers = new ObservableCollection<Teacher>();
    }
        public async Task GetAllUsers(){
            var admins = await _adminRepository.GetAllAsync();
            var students = await _studentRepository.GetAllAsync();
            var teachers = await _teacherRepository.GetAllAsync();
            
            foreach (var a in admins)
            {
                Admins.Add(a);
            }

            foreach (var s in students)
            {
                Students.Add(s);
            }
            
            foreach (var t in teachers)
            {
                Teachers.Add(t);
            }
        }
    }
}