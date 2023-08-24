using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public class EmailValidator
    {


            
        


        public bool Validate(string email)
        {


            var pattern = @"@mail.com$";

            var regex = new Regex(pattern);
             

            
            if (email.Length < 10)
            {
                throw new Exception("ShortMailException");
            }
            if (regex.IsMatch(email)==false)
            {
                throw new Exception("NotAnEmailAddressException");

            }

            return true;

        }
        
    }
}
