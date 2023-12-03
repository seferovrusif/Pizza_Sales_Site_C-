using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskff.Utilies.Exceptions
{
    public class PizzaNotFoundException : Exception
    {
        public PizzaNotFoundException(string message) : base(message)
        {
        }
    }


    public class WrongNameException : Exception
    {
        public WrongNameException(string message) : base(message)
        {
        }
    }
    public class WrongSurNameException : Exception
    {
        public WrongSurNameException(string message) : base(message)
        {
        }
    }
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message)
        {
        }
    }
    public class WrongUsernameException : Exception
    {
        public WrongUsernameException(string message) : base(message)
        {
        }
    }
    public class WrongCount : Exception
    {
        public WrongCount(string message) : base(message)
        {
        }
    }
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) : base(message)
        {

        }
    }
}
