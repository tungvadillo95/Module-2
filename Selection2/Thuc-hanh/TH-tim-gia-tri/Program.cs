using System;

namespace TH_tim_gia_tri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if ((students[i].ToUpper()).Equals(input_name.ToUpper()))
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");
            }
        }
    }
}
