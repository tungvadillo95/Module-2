using System;
using System.Collections.Generic;
using System.Globalization;

namespace DemergingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();


            Student student1 = new Student()
            {
                Gender = true,
                Name = "Torres",
                DateOfBirth = new DateTime(1995, 10, 19)
            };
            Student student2 = new Student()
            {
                Gender = false,
                Name = "Elis",
                DateOfBirth = new DateTime(1997, 10, 30)
            };
            Student student3 = new Student()
            {
                Gender = true,
                Name = "Gerrad",
                DateOfBirth = new DateTime(1995, 5, 25)
            };
            Student student4 = new Student()
            {
                Gender = false,
                Name = "Juliest",
                DateOfBirth = new DateTime(1994, 7, 27)
            };
            list.Add(student1);
            list.Add(student2);
            list.Add(student3);
            list.Add(student4);
            list.Sort((x, y) => DateTime.Compare(x.DateOfBirth, y.DateOfBirth));
            Queue<Student> listNam = new Queue<Student>();
            Queue<Student> listNu = new Queue<Student>();
            List<Student> listResult = new List<Student>();
            foreach (Student student in list)
            {
                if (student.Gender)
                {
                    listNam.Enqueue(student);
                }
                else
                {
                    listNu.Enqueue(student);
                }
            }
            foreach(Student student in listNu)
            {
                listResult.Add(student);
            }
            foreach (Student student in listNam)
            {
                listResult.Add(student);
            }
            foreach(Student student in listResult)
            {
                Console.WriteLine($"Gender: {(student.Gender ? "Nam" : "Nu")}" +
                    $", Name: {student.Name}" +
                    $", Date of birth(dd/mm/yyyy): {student.DateOfBirth.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
