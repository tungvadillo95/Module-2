using System;
using System.Text.RegularExpressions;

namespace ValidateNameClass
{
    class Program
    {
        private static NameClass nameClassTest;
        static string[] validateNameClass = new String[] { "C0318G", "A1234M", "P2222K" };
        static string[] invalidateNameClass = new String[] { "M0318G", "P0323A", "1234G", "C0504A" };
        static void Main(string[] args)
        {
            nameClassTest = new NameClass();
            foreach (var email in validateNameClass)
            {
                bool isvalid = nameClassTest.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isvalid);
            }
            foreach (var email in invalidateNameClass)
            {
                bool isvalid = nameClassTest.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isvalid);
            }
        }
    }
    public class NameClass
    {
        static String NAME_CLASS_REGEX = "^[CAP][0-9]{4}[G-M]$";
        public bool Validate(string regex)
        {
            bool isMatch = Regex.IsMatch(regex, NAME_CLASS_REGEX);
            return isMatch;
        }
    }
}
