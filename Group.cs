using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Models
{
    class Group
    {
        public string Name { get; set; }
        public int MaxStuCount { get; set; }
        public int ExamPoint;
        public int[] CurrentStudent;
        public int[] NewStudent;
        public Student[] Students { get; set; }

        public Group(string name, int maxStuCount, params Student[] students)
        {
            Name = name;
            MaxStuCount = maxStuCount;
            Students = students;

        }
        public void RemoveStudent(Student students)
        {
            if (ExamPoint <= 81)
            {
                Console.WriteLine($"Student is removed, MaxStuCount-{MaxStuCount}");
            }
            Console.WriteLine("Student is successed");
        }
        public void AddStudent()
        {
            if (MaxStuCount > CurrentStudent.Length + NewStudent.Length)
            {
                MaxStuCount++;
                Console.WriteLine($"New student is accepted, New count-{MaxStuCount} ");
            }
            Console.WriteLine("Limit is overrated");
             foreach (var item in Students)
	         {
              Console.WriteLine(item);
             }
        }
    }   
}
