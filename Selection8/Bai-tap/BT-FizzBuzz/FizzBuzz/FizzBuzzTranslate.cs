using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzService
{
    public class FizzBuzzTranslate
    {
        const int DIVISOR_1 = 3;
        const int DIVISOR_2 = 5;
        const string EXPECTED_DIVISOR_1 = "Fizz";
        const string EXPECTED_DIVISOR_2 = "Buzz";
        const string EXPECTED_DIVISOR_12 = "FizzBuzz";
        public string Traslate(byte number)
        {
            string result = $"Number {number}";
            bool isFizz = number % DIVISOR_1 == 0;
            bool isBuzz = number % DIVISOR_2 == 0;
            if (isFizz && isBuzz)
            {
                result = EXPECTED_DIVISOR_12;
            }
            else if (isFizz)
            {
                result = EXPECTED_DIVISOR_1;
            }
            else if (isBuzz)
            {
                result = EXPECTED_DIVISOR_2;
            }
            string str = number.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == char.Parse(DIVISOR_1.ToString()))
                {
                    result += "-" + EXPECTED_DIVISOR_1;
                }
                if (str[i] == char.Parse(DIVISOR_2.ToString()))
                {
                    result += "-" + EXPECTED_DIVISOR_2;
                }
            }
            return result += ReadNumber(number);
        }
        public static string ReadNumber(byte number)
        {
            string readNumber = "";
            if (number >= 100 || number < 0)
            {
                Console.WriteLine("Out of ability");
            }
            if (number < 10)
            {
                switch (number)
                {
                    case 0:
                        readNumber = "Zero";
                        break;
                    case 1:
                        readNumber = "One";
                        break;
                    case 2:
                        readNumber = "Two";
                        break;
                    case 3:
                        readNumber = "Three";
                        break;
                    case 4:
                        readNumber = "For";
                        break;
                    case 5:
                        readNumber = "Five";
                        break;
                    case 6:
                        readNumber = "Six";
                        break;
                    case 7:
                        readNumber = "Seven";
                        break;
                    case 8:
                        readNumber = "Eight";
                        break;
                    case 9:
                        readNumber = "Nine";
                        break;
                }
            }
            else if (number < 20)
            {
                switch (number % 10)
                {
                    case 0:
                        readNumber = "Ten";
                        break;
                    case 1:
                        readNumber = "Eleven";
                        break;
                    case 2:
                        readNumber = "Twelve";
                        break;
                    case 3:
                        readNumber = "Thirteen";
                        break;
                    case 4:
                        readNumber = "Forteen";
                        break;
                    case 5:
                        readNumber = "Fifteen";
                        break;
                    case 6:
                        readNumber += "Sixteen";
                        break;
                    case 7:
                        readNumber = "Seventeen";
                        break;
                    case 8:
                        readNumber = "Eighteen";
                        break;
                    case 9:
                        readNumber = "Nineteen";
                        break;
                }
            }
            else if (number < 100)
            {
                switch (number / 10)
                {
                    case 2:
                        readNumber = "Twenty";
                        break;
                    case 3:
                        readNumber = "Thirty";
                        break;
                    case 4:
                        readNumber = "Forty";
                        break;
                    case 5:
                        readNumber = "Fifty";
                        break;
                    case 6:
                        readNumber = "Sixty";
                        break;
                    case 7:
                        readNumber = "Seventy";
                        break;
                    case 8:
                        readNumber = "Eighty";
                        break;
                    case 9:
                        readNumber = "Ninety";
                        break;
                }
                switch (number % 10)
                {
                    case 1:
                        readNumber += " one";
                        break;
                    case 2:
                        readNumber += " two";
                        break;
                    case 3:
                        readNumber += " three";
                        break;
                    case 4:
                        readNumber += " for";
                        break;
                    case 5:
                        readNumber += " five";
                        break;
                    case 6:
                        readNumber += " six";
                        break;
                    case 7:
                        readNumber += " seven";
                        break;
                    case 8:
                        readNumber += " eight";
                        break;
                    case 9:
                        readNumber += " nine";
                        break;
                }
            }
            return $" : {readNumber}";
        }
    }
}
