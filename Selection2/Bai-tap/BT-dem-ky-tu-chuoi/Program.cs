using System;

namespace BT_dem_ky_tu_chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            char value;
            string str = GenerateString();
            Console.WriteLine("Enter char to search");
            value = char.Parse(Console.ReadLine());
            CountChar(str, value);
        }
        public static string GenerateString()
        {
            string str;
            Console.WriteLine("Enter string ");
            str = Console.ReadLine();
            return str;
        }
        public static void CountChar(string str, char value)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().ToUpper() == value.ToString().ToUpper())
                {
                    count++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine("The number of char \"" + value + "\" in the string is " + count);
            }
            else
            {
                Console.WriteLine("Char is not in string!");
            }
        }
    }
}
