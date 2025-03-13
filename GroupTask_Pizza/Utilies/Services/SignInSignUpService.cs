using GroupTask_Pizza.Models;

namespace GroupTask_Pizza.Utilies.Services
{
    internal static class SignInSignUpService
    {

        public static int SignIn(string name, string password)
        {
            var a = Database.Users.FirstOrDefault(x => x.mail == name);
            if (a == null)
            {
                Console.WriteLine("user not found");
                return -1;
            }
            else
            {
                if (a.password == password)
                {
                    Console.WriteLine($"Welcome, {a.Name} {a.Surname}");
                    return a.Id;
                }
                else
                {
                    Console.WriteLine("pasword is wrong!");
                    return -1;
                }
            }
        }
        public static void SignUp(string name, string surname, string mail, string password)
        {
            var a = Database.Users.FirstOrDefault(y => y.mail == mail);
            if (a == null)
            {
                User user = new User(mail, password, name, surname);
                Database.Users.Add(user);
                Console.WriteLine("User Created.");

            }
            else
            {
                Console.WriteLine("User already exists!");
            }
        }
    }
}


