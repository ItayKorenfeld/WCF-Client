using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LoginRegister
{
    
    public class NoLettersRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            int h;
            bool s = Int32.TryParse(str, out h);
            if (s)
            {
                if (h < 1)
                    return new ValidationResult(false, "Must be greeter then 0");
                return new ValidationResult(true, null);

            }
            return new ValidationResult(false, "Can contain only digits");
        }
    }
        public class OnlyLettersRule : ValidationRule
        {
            public override ValidationResult Validate(object value, CultureInfo cultureInfo)
            {
                string str = value as string;

                bool containsInt = str.Any(char.IsDigit);
                if (containsInt)
                {

                    return new ValidationResult(false, "Must contain only letters");


                }
                else if (str.Length == 0)
                {
                    return new ValidationResult(false, "Empty");
                }
                return new ValidationResult(true, null);

            
        }
    }
    public class ExactLength : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            if(str.Length>9 || str.Length < 9)
            {
                return new ValidationResult(false, "Must contain 9 digits");
            }
            return new ValidationResult(true, null);
        }
    }
    public class ExactLength1 : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            if (str.Length > 10 || str.Length < 10)
            {
                return new ValidationResult(false, "Must contain 10 digits");
            }
            return new ValidationResult(true, null);
        }
    }


}
