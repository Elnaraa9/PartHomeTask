using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Group student = new Group();
            student.Name = "Elnara";
            student.Surname = "Vahabova";

            student.AddStudent();
            student.RemoveStudent();
            Console.WriteLine(student.Name,student.Surname,student);
        }
    }
}
