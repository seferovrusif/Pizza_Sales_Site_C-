using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTask_Pizza.Models
{
    internal class User
    {
        static private int _id = 1;
        public int Id { get; }
        public string mail { get; set; }
        public string password { get; set; }
        public Role role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string mail,string password,string name,string surname)
        {
            Id = _id;
            _id++;
            this.mail = mail;   
            this.password = password;
            role = Role.Member;
            this.Name = name;
            this.Surname = surname;
        }
        public override string ToString()
        {
            return $"Id=> {Id}  mail: {mail}  password: {password}  role: {role}  Name: {Name}  Surname: {Surname}";
        }

    }
}
