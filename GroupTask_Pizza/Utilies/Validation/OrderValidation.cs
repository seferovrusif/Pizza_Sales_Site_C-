using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GroupTask_Pizza.Utilies.Validation
{
    internal static class OrderValidation
    {
        public static bool PhoneValidation(string phone)
        {
            Regex regex = new Regex(@"^(55|70|77|50|51)[-.\s]?([0-9]{3})[-.\s]?([0-9]{2})[-.\s]?([0-9]{2})$");
            Match match = regex.Match(phone);
            return match.Success;
        }
    }
}
