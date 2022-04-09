using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.data.models
{
    public class Student : Person
    {
        public string StudentId { get; set; }


        public Student(string studentId,string Name , string Surname , string Password, String Role,  string Email) :base(Name, Surname, Password, Role,Email)
        {
            this.StudentId = studentId;
        }

        
    }
}
