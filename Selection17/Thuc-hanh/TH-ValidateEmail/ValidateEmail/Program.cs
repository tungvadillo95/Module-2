using System;
using System.Text.RegularExpressions;

namespace ValidateEmail
{
    class Program
    {
        static EmailExample emailExample;
        static string[] validEmail = new string[] { "a@gmail.com", "ab@yahoo.com", "abc@hotmail.com" };
        static string[] invalidEmail = new string[] { "@gmail.com", "ab@gmail.", "@#abc@gmail.com" };

        static void Main(string[] args)
        {
            emailExample = new EmailExample();
            foreach (var email in validEmail)
            {
                bool isvalid = emailExample.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isvalid);
            }
            foreach (var email in invalidEmail)
            {
                bool isvalid = emailExample.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isvalid);
            }
        }
        public class EmailExample
        {
            private static string EMAIL_REGEX = "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$";
            public bool Validate(string regex)
            {
                bool matcher = Regex.IsMatch(regex, EMAIL_REGEX);
                return matcher;
            }
        }
    }
}
