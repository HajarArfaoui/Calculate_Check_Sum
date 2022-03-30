using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculateCheckDigit
{
    public class CheckDigit
    {
        public static string calculate_check_digit(string upcCode)
        {
            int sum = 0, checkDigit;
            if (upcCode.Length != 11 || upcCode != (new Regex("[^0-9]")).Replace(upcCode, ""))
            {
                return "";
            }
            char[] characters = upcCode.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                sum += i % 2 == 0 ? int.Parse(characters[i].ToString()) * 3 : int.Parse(characters[i].ToString());
            }
            checkDigit = sum % 10 == 0 ? 0 : 10 - sum % 10;
            return String.Concat(upcCode, checkDigit);

        }
        static void Main(string[] args)
        {
        }
    }
}
