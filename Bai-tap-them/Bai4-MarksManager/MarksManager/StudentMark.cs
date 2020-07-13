using System;
using System.Collections.Generic;
using System.Text;

namespace MarksManager
{
    class StudentMark: IStudentMark
    {
        #region Property
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Class { get; set; }
        public int Semester { get; set; }
        private float AverageMark=-1 ;
        #endregion
        #region Method
        public void Display()
        {
            if (AverageMark != -1)
            {
                Console.WriteLine($"Full name: {FullName}, ID: {ID}, Class: {Class}, Semester: {Semester},Average mark: {AverageMark}");
            }
            else
            {
                Console.WriteLine($"Full name: {FullName}, ID: {ID}, Class: {Class}, Semester: {Semester}");
            }
        }
        public const int LENGTH_SUBJECT_MARK_LIST = 5;
        public float[] SubjectMarkList = new float[LENGTH_SUBJECT_MARK_LIST];
        public void AveCal()
        {
            float sum = 0;
            for (int i = 0; i < SubjectMarkList.Length; i++)
            {
                sum += SubjectMarkList[i];
            }
            AverageMark = sum / SubjectMarkList.Length;
        }
        #endregion
    }
}
