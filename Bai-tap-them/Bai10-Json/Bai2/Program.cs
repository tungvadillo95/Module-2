using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai10-Json\Bai2\data";
            string fileInput = "data.json";
            string fileOutput = "Outcome.json";
            // Doc va console file data.json
            var result = new Data();
            using (StreamReader sr = File.OpenText($@"{filePath}\{fileInput}"))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Data>(data);
            }
            Console.WriteLine($"MaHS\tHoTen\t\t   GioiTinh\tToan\tLy\tHoa\tDTB");
            foreach (var student in result.students)
            {
                Console.WriteLine(student.ToString());
            }
            // Tao va viet Outcome.jason
            var response = new Response()
            {
                students = new List<ResStudent>()
            };
            foreach (var std in result.students)
            {
                response.students.Add(new ResStudent()
                {
                    MaHS = std.MaHS,
                    HoTen = std.HoTen,
                    GioiTinh = std.GioiTinh,
                    MonHoc = std.MonHoc
                });
            }
            response.students.Sort(delegate(ResStudent x, ResStudent y)
            {
                if (x.DTB == y.DTB) return 0;
                else if (x.DTB > y.DTB) return -1;
                else if (x.DTB < y.DTB) return 1;
                else return x.DTB.CompareTo(y.DTB);
            });

            using (StreamWriter sw = File.CreateText($@"{filePath}\{fileOutput}"))
            {
                var data = JsonConvert.SerializeObject(response);
                sw.Write(data);
            }
        }
    }
    public class Response
    {
        public List<ResStudent> students { get; set; }
    }
    public class ResStudent : Student
    {
        public float DTB => DiemTrungBinh();
        public string XepLoai => Rank();

        private string Rank()
        {
            if (DTB >= 9)
            {
                return "Xuat sac";
            }
            if (DTB >= 8)
            {
                return "Gioi";
            }
            if (DTB >= 7)
            {
                return "Kha";
            }
            if (DTB >= 6.5)
            {
                return "TBK";
            }
            if (DTB >= 5)
            {
                return "Trung Binh";
            }
            if (DTB >= 3.5)
            {
                return "Yeu";
            }
            return "Kem";
        }
    }
    public class Data
    {
        public List<Student> students { get; set; }
    }
    public class MonHoc
    {
        public string TenMon { get; set; }
        public int Diem { get; set; }
    }
    public class Student
    {
        public int MaHS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public List<MonHoc> MonHoc { get; set; }
        public float DiemTrungBinh()
        {
            float total = 0;
            foreach (var item in MonHoc)
            {
                if (item.TenMon == "Toan")
                {
                    total += item.Diem * 2;
                }
                else
                {
                    total += item.Diem;
                }
            }
            return total / (MonHoc.Count + 1);
        }
        public override string ToString()
        {
            return $"{MaHS}\t{HoTen}\t\t{GioiTinh}\t{MonHoc[0].Diem}\t{MonHoc[1].Diem}\t{MonHoc[2].Diem}\t{DiemTrungBinh()}";
        }
    }
}
