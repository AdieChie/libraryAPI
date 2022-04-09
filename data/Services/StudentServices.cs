using BookLibraryApi.data.models;
using BookLibraryApi.data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.data.Services
{
    public class StudentServices
    {
        private AppDbContext _context;
        public StudentServices(AppDbContext context)
        {
            _context = context;
        }
        public void AddStudent(Student student)
        {
            var _student = new Student()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Surname = student.Surname,
                Password = student.Password,
                Role = student.Role,
                Email = student.Email,
                
            };
            _context.Students.Add(_student);
            _context.SaveChanges();
        }
    }
}
