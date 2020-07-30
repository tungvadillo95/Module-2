using System;
using System.Text.RegularExpressions;

namespace ValidatePhoneNumber
{
    class Program
    {
        private static PhoneNumberClass phoneNumberTest;
        static string[] validatePhoneNumber = new String[] { "(84)-(0978489648)" };
        static string[] invalidatePhoneNumber = new String[] { "(a8)-(22222222)" };

        static void Main(string[] args)
        {
            phoneNumberTest = new PhoneNumberClass();
            foreach (var email in validatePhoneNumber)
            {
                bool isvalid = phoneNumberTest.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isvalid);
            }
            foreach (var email in invalidatePhoneNumber)
            {
                bool isvalid = phoneNumberTest.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isvalid);
            }
        }
        public class PhoneNumberClass
        {
            static String PHONE_NUMBER_REGEX = "^[(][0-9]{2}[)][-][(]0[0-9]{9}[)]$";
            public bool Validate(string regex)
            {
                bool isMatch = Regex.IsMatch(regex, PHONE_NUMBER_REGEX);
                return isMatch;
            }
        }
    }
}
