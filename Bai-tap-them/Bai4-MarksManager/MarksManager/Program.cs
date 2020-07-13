using System;

namespace MarksManager
{
    class Program
    {
        public static StudentMark[] studentList = new StudentMark[0];
        static void Main(string[] args)
        {
            byte choice = 5;
            while (choice != 4)
            {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Insert new Student...");
            Console.WriteLine("2. View list of Student...");
            Console.WriteLine("3. Average Mark...");
            Console.WriteLine("4. Exit");
            Console.Write("Option: ");
            choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert new Student...");
                        CreatStudentInfo();
                        break;
                    case 2:
                        Console.WriteLine("View list of Student...");
                        for (int i = 0; i < studentList.Length; i++)
                        {
                            studentList[i].Display();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Average Mark...");
                        for (int i = 0; i < studentList.Length; i++)
                        {
                            studentList[i].AveCal();
                            studentList[i].Display();
                        }
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
            StudentMark newstudent = new StudentMark();
            Console.Write("Please input student fullname: ");
            newstudent.FullName = Console.ReadLine();
            Console.Write("Please input class name: ");
            newstudent.Class = Console.ReadLine();
            Console.Write("Please input semester: ");
            newstudent.Semester = int.Parse(Console.ReadLine());
            for (int i = 0; i < newstudent.SubjectMarkList.Length; i++)
            {
                Console.Write($"Please input marks of subject {i + 1}: ");
                newstudent.SubjectMarkList[i] = float.Parse(Console.ReadLine());
            }
            Array.Resize(ref studentList, studentList.Length + 1);
            studentList[studentList.Length - 1] = newstudent;
            newstudent.ID = studentList.Length;
        }
    }
}
