using System.Text.RegularExpressions;

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
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            while (!UserValidation.NameValidation(name))
            {
                Console.WriteLine("The name is incorrect, please re-enter it.");
                name = Console.ReadLine();
            }
            Console.WriteLine("Enter Surname:");
            string surname = Console.ReadLine();
            while (!UserValidation.SurnameValidation(surname))
            {
                Console.WriteLine("The Surname is incorrect, please re-enter it");
                surname = Console.ReadLine();
            }
            Console.WriteLine("Enter Mail:");
            string mail2 = Console.ReadLine();
            while (!UserValidation.MailValidation(mail2))
            {
                Console.WriteLine("The mail is incorrect, please re-enter it");
                mail2 = Console.ReadLine();
            }
            Console.WriteLine("Enter Password:");
            string password2 = Console.ReadLine();
            while (!UserValidation.PasswordValidation(password2))
            {
                Console.WriteLine("The Password is incorrect, please re-enter it");
                password2 = Console.ReadLine();
            }
            return (name, surname, mail2, password2);
        }
    }
}
