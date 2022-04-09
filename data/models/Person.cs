using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.data.models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string  Surname { get; set; }
        public string Password { get; set; }
        public string  Role { get; set; }
        public string Email { get; set; }


        public Person(string Name, string Surname, string Password, string Role, string Email)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Password = Password;
            this.Role = Role;
            this.Email = Email;
        }
    }
}
