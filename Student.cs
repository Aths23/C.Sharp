using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    class Student : IComparable<Student>
    {
        private int studentId;
        private string studentName;
        private int studentPercentage;

        public Student(int studentId, string studentName, int studentPercentage)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentPercentage = studentPercentage;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int StudentPercentage { get => studentPercentage; set => studentPercentage = value; }

        public int CompareTo(Student s2)
        {
            return this.studentPercentage - s2.studentPercentage;
        }

        public override string ToString()
        {
            return $"Student Id {studentId} , Student Name {studentName}, Student Percentage {studentPercentage}";
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            List<Student> sList = new List<Student>();
            sList.Add(new Student(1, "Atharva", 81));
            sList.Add(new Student(3, "Gautam", 91));
         }
    }
}
