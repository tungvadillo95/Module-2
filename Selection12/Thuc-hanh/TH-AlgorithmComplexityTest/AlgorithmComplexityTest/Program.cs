using System;

namespace AlgorithmComplexityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            /*codes below here */

            int[] frequentChar = new int[255];
            for (int i = 0; i < inputString.Length; i++)
            {
                /* Tìm ví trí tương ứng của ký tự trong bảng ASCII */
                int ascii = (int)inputString[i];
                /* Tăng giá trị tần suất */
                frequentChar[ascii] += 1;
            }

            int max = 0;
            char character = (char)255; /* empty character */
            for (int j = 0; j < 255; j++)
            {
                if (frequentChar[j] > max)
                {
                    max = frequentChar[j];
                    character = (char)j;
                }
            }
            Console.WriteLine("The most appearing letter is '" + character + "' with a frequency of " + max + " times");
        }
    }
}
