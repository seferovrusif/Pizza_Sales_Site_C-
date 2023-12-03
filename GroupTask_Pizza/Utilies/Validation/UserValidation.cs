﻿using GroupTask_Pizza.Utilies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GroupTask_Pizza.Utilies.Validation
{
    internal static class UserValidation
    {
        public static bool NameValidation(string name)
        {
            Regex regex = new Regex("^[A-Z]{1}[a-z]{2,16}$");
            Match match = regex.Match(name);
            return match.Success;
        }
        public static bool SurnameValidation(string surname)
        {
            Regex regex = new Regex("^[A-Z]{1}[a-z]{2,16}$");
            Match match = regex.Match(surname);
            return match.Success;
        }
        public static bool MailValidation(string mail)
        {
            Regex regex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            Match match = regex.Match(mail);
            return match.Success;

        }
        public static bool PasswordValidation(string password)
        {
            Regex regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,16}$");
            Match match = regex.Match(password);
            return match.Success;
        }
        public static (string,string,string,string) SignUpValidation()
        {
            Console.WriteLine("Ad daxil edin:");
            string name = Console.ReadLine();
            while (!UserValidation.NameValidation(name))
            {
                Console.WriteLine("Adi sehvdir, yeniden daxil edin");
                name = Console.ReadLine();
            }
            Console.WriteLine("Soyad daxil edin:");
            string surname = Console.ReadLine();
            while (!UserValidation.SurnameValidation(surname))
            {
                Console.WriteLine("Soyad sehvdir, yeniden daxil edin");
                surname = Console.ReadLine();
            }
            Console.WriteLine("Mail daxil edin:");
            string mail2 = Console.ReadLine();
            while (!UserValidation.MailValidation(mail2))
            {
                Console.WriteLine("Mail sehvdir, yeniden daxil edin");
                mail2 = Console.ReadLine();
            }
            Console.WriteLine("Shifre daxil edin:");
            string password2 = Console.ReadLine();
            while (!UserValidation.PasswordValidation(password2))
            {
                Console.WriteLine("Sifre sehvdir, yeniden daxil edin");
                password2 = Console.ReadLine();
            }
            return (name, surname, mail2, password2);
        }
    }
}
