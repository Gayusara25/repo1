/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26aug
{
    internal class program1
    {


        static void Main(string[] args)
        {
            Student[] stu = { new Student(), new Student(), new Student() };

            stu[0].SetStudent(1, "Gayathri", 45);
            stu[1].SetStudent(2, "Visalini", 47);
            stu[2].SetStudent(3, "Sai",35);

            stu[0].DisplayStudent();
            stu[1].DisplayStudent();
            stu[2].DisplayStudent();
        }
    }
    public struct Student
    {

        
       
        public int Id;
        public string Name;
        public int Marks;

        
        public void SetStudent(int id, string name, int marks)
        {
            Id = id;
            Name = name;
           Marks = marks;
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Student:");
            Console.WriteLine("\tId    : " + Id);
            Console.WriteLine("\tName   : " + Name);
            Console.WriteLine("\tMarks   : " + Marks);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}

    */    