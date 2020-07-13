using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerSystem
{
    class Student : IStudent
    {
        #region Property
        public string FullName { get; set; }
        public int ID { get; set; }
        public string DateOfBirth { get; set; }
        public string Native { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }
        #endregion
        #region Method
        public void Display()
        {
            Console.WriteLine($"Full name: {FullName}, ID: {ID}, Date of birth: {DateOfBirth}, Native: {Native}, Class: {Class}, Phone no: {PhoneNo}, Mobile: {Mobile}");
        }
        #endregion
    }
}
