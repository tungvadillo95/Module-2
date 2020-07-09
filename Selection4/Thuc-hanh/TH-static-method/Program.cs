using System;

namespace TH_static_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Change();
            Student s1 = new Student(111, "Hoang");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");
            s1.Display();
            s2.Display();
            s3.Display();
        }
    }
    public class Student
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";
        public Student(int r, string n)
        {
            rollno = r;
            name = n;
        }
        public static void Change()
        {
            college = "CODEGYM";
        }
        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}
