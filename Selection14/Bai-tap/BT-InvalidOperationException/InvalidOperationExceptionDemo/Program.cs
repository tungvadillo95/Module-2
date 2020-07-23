using System;
using System.Collections.Generic;

namespace InvalidOperationExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> listPerson = new List<Person>();
                for (int i=0; i<=listPerson.Count; i++)
                {
                    listPerson.Remove(listPerson[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
