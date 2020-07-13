using System;

namespace StudentManagerSystem
{
    class Program
    {
        public static Student[] studentList = new Student[0];
        static void Main(string[] args)
        {
            byte choice = 5;
            while (choice != 4)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Insert new Student");
                Console.WriteLine("2. View list of Students");
                Console.WriteLine("3. Search Students");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert new Student");
                        CreatStudentInfo();
                        break;
                    case 2:
                        Console.WriteLine("View list of Students");
                        for (int i = 0; i < studentList.Length; i++)
                        {
                            studentList[i].Display();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Search Students");
                        string classStudent;
                        Console.Write("Please input the class name to search: ");
                        classStudent = Console.ReadLine();
                        SearchClass(classStudent);

                        break;
                    case 4:
                        Console.WriteLine("End program !");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        public static void CreatStudentInfo()
        {
            Student newstudent = new Student();
            Console.Write("Please input student fullname: ");
            newstudent.FullName = Console.ReadLine();
            Console.Write("Please input date of birth: ");
            newstudent.DateOfBirth = Console.ReadLine();
            Console.Write("Please input native: ");
            newstudent.Native = Console.ReadLine();
            Console.Write("Please input class: ");
            newstudent.Class = Console.ReadLine();
            Console.Write("Please input phone no: ");
            newstudent.PhoneNo = Console.ReadLine();
            Console.Write("Please input mobile: ");
            newstudent.Mobile = int.Parse(Console.ReadLine());
            Array.Resize(ref studentList, studentList.Length + 1);
            studentList[studentList.Length - 1] = newstudent;
            newstudent.ID = studentList.Length;
        }
        public static void SearchClass(string classStudent)
        {
            int check = 0;
        for(int i=0; i< studentList.Length; i++)
            {
                if (studentList[i].Class == classStudent)
                {
                    studentList[i].Display();
                    check++;
                }
            }
        if (check == 0)
            {
                Console.WriteLine("Class name does not exist!");
            }
        }
    }
}
