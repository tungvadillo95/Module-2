using System;

namespace BT_doc_so
{
    class Program
    {
        static void Main(string[] args)
        {
            int youNumber;
            String readNumber = "";
            Console.WriteLine("Enter your number: ");
            youNumber = Convert.ToInt32(Console.ReadLine());
            if (youNumber >= 1000 || youNumber < 0)
            {
                Console.WriteLine("Out of ability");
            }
            if (youNumber < 10)
            {
                switch (youNumber)
                {
                    case 0:
                        Console.WriteLine("Your number " + youNumber + " : Zero");
                        break;
                    case 1:
                        Console.WriteLine("Your number " + youNumber + " : One");
                        break;
                    case 2:
                        Console.WriteLine("Your number " + youNumber + " : Two");
                        break;
                    case 3:
                        Console.WriteLine("Your number " + youNumber + " : Three");
                        break;
                    case 4:
                        Console.WriteLine("Your number " + youNumber + " : For");
                        break;
                    case 5:
                        Console.WriteLine("Your number " + youNumber + " : Five");
                        break;
                    case 6:
                        Console.WriteLine("Your number " + youNumber + " : Six");
                        break;
                    case 7:
                        Console.WriteLine("Your number " + youNumber + " : Seven");
                        break;
                    case 8:
                        Console.WriteLine("Your number " + youNumber + " : Eight");
                        break;
                    case 9:
                        Console.WriteLine("Your number " + youNumber + " : Nine");
                        break;
                }
            }
            else if (youNumber < 20)
            {
                switch (youNumber % 10)
                {
                    case 0:
                        Console.WriteLine("Your number " + youNumber + " : Ten");
                        break;
                    case 1:
                        Console.WriteLine("Your number " + youNumber + " : Eleven");
                        break;
                    case 2:
                        Console.WriteLine("Your number " + youNumber + " : Twelve");
                        break;
                    case 3:
                        Console.WriteLine("Your number " + youNumber + " : Thirteen");
                        break;
                    case 4:
                        Console.WriteLine("Your number " + youNumber + " : Forteen");
                        break;
                    case 5:
                        Console.WriteLine("Your number " + youNumber + " : Fifteen");
                        break;
                    case 6:
                        Console.WriteLine("Your number " + youNumber + " : Sixteen");
                        break;
                    case 7:
                        Console.WriteLine("Your number " + youNumber + " : Seventeen");
                        break;
                    case 8:
                        Console.WriteLine("Your number " + youNumber + " : Eighteen");
                        break;
                    case 9:
                        Console.WriteLine("Your number " + youNumber + " : Nineteen");
                        break;
                }
            }
            else if (youNumber < 100)
            {
                switch (youNumber / 10)
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
                switch (youNumber % 10)
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
                Console.WriteLine("Your number " + youNumber + " :" + readNumber);
            }
            else if (youNumber < 1000 && (youNumber % 100 > 20))
            {
                switch (youNumber / 100)
                {
                    case 1:
                        readNumber = "One hundred";
                        break;
                    case 2:
                        readNumber = "Two hundred";
                        break;
                    case 3:
                        readNumber = "Three hundred";
                        break;
                    case 4:
                        readNumber = "For hundred";
                        break;
                    case 5:
                        readNumber = "Five hundred";
                        break;
                    case 6:
                        readNumber = "Six hundred";
                        break;
                    case 7:
                        readNumber = "Seven hundred";
                        break;
                    case 8:
                        readNumber = "Eight hundred";
                        break;
                    case 9:
                        readNumber = "Nine hundred";
                        break;
                }
                switch (youNumber / 10 % 10)
                {
                    case 2:
                        readNumber += " and twenty";
                        break;
                    case 3:
                        readNumber += " and thirty";
                        break;
                    case 4:
                        readNumber += " and forty";
                        break;
                    case 5:
                        readNumber += " and fifty";
                        break;
                    case 6:
                        readNumber += " and sixty";
                        break;
                    case 7:
                        readNumber += " and seventy";
                        break;
                    case 8:
                        readNumber += " and eighty";
                        break;
                    case 9:
                        readNumber += " and ninety";
                        break;
                }
                switch (youNumber % 10)
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
                Console.WriteLine("Your number " + youNumber + " :" + readNumber);
            }
            if (youNumber < 1000 && youNumber > 100 && youNumber % 100 < 20)
            {
                switch (youNumber / 100)
                {
                    case 1:
                        readNumber = "One hundred";
                        break;
                    case 2:
                        readNumber = "Two hundred";
                        break;
                    case 3:
                        readNumber = "Three hundred";
                        break;
                    case 4:
                        readNumber = "For hundred";
                        break;
                    case 5:
                        readNumber = "Five hundred";
                        break;
                    case 6:
                        readNumber = "Six hundred";
                        break;
                    case 7:
                        readNumber = "Seven hundred";
                        break;
                    case 8:
                        readNumber = "Eight hundred";
                        break;
                    case 9:
                        readNumber = "Nine hundred";
                        break;
                }
                switch (youNumber % 100)
                {
                    case 1:
                        {
                            readNumber += " and one";
                            break;
                        }
                    case 2:
                        {
                            readNumber += " and two";
                            break;
                        }
                    case 3:
                        {
                            readNumber += " and three";
                            break;
                        }
                    case 4:
                        {
                            readNumber += " and four";
                            break;
                        }
                    case 5:
                        {
                            readNumber += " and five";
                            break;
                        }
                    case 6:
                        {
                            readNumber += " and six";
                            break;
                        }
                    case 7:
                        {
                            readNumber += " and seven";
                            break;
                        }
                    case 8:
                        {
                            readNumber += " and eight";
                            break;
                        }
                    case 9:
                        {
                            readNumber += " and nine";
                            break;
                        }
                    case 10:
                        {
                            readNumber += " and ten";
                            break;
                        }
                    case 11:
                        {
                            readNumber += " and eleven";
                            break;
                        }
                    case 12:
                        {
                            readNumber += " and twelve";
                            break;
                        }
                    case 13:
                        {
                            readNumber += " and thirteen";
                            break;
                        }
                    case 14:
                        {
                            readNumber += " and fourteen";
                            break;
                        }
                    case 15:
                        {
                            readNumber += " and fiveteen";
                            break;
                        }
                    case 16:
                        {
                            readNumber += " and sixteen";
                            break;
                        }
                    case 17:
                        {
                            readNumber += " and seventeen";
                            break;
                        }
                    case 18:
                        {
                            readNumber += " and eighteen";
                            break;
                        }
                    case 19:
                        {
                            readNumber += " and nineteen";
                            break;
                        }
                }
                Console.WriteLine("Your number " + youNumber + " :" + readNumber);
            }
        }
    }
}
