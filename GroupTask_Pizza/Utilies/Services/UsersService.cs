using GroupTask_Pizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupTask_Pizza.Utilies.Services
{
    internal static class UsersService
    {
      
        
        public static User GetUserById(int id)
        {
            return Database.Users.Find(p => p.Id == id);
        }
        public static void GetAllUsers()
        {
            Database.Users.ForEach(u => Console.WriteLine(u));
        }
       
       
        
        public static void RemoveUser(int id)
        {
            Database.Users.Remove(GetUserById(id));
        }
        public static void UpdateUser(int id)
        {
            var a = GetUserById(id);
            Console.WriteLine($"User role: {a.role}\nPress 1 if you want to change the role, Otherwise, press a different button");
            string b = Console.ReadLine();
            if (b == "1")
            {
                if (a.role == Role.Admin)
                {
                    a.role = Role.Member;
                }
                else
                {
                    a.role = Role.Admin;
                }
            }
        }
        
     
    }
}
