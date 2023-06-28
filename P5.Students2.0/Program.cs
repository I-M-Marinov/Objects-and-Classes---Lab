using System;
using System.Collections.Generic;
using System.Linq;

namespace P4.Students
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string age { get; set; }
        public string homeTown { get; set; }

    }
    internal class Program
    {
        static bool StudentExists(List<Student> studentList, string firstName, string lastName)
        {
            foreach (Student student in studentList)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> studentList, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in studentList)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        } 

        static void Main(string[] args)
        {
            string input = "";
            List<Student> studentsList = new List<Student>();

            while (input != "end")
            {

                List<string> inputList = Console.ReadLine().Split().ToList();

                input = inputList[0];
                if (input == "end")
                {
                    break;
                }

                string firstName = inputList[0];
                string lastName = inputList[1];
                string age = inputList[2];
                string city = inputList[3];

                Student student = new Student();

                if (StudentExists(studentsList, firstName, lastName))
                { 
                    student = GetStudent(studentsList, firstName, lastName);

                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = city;
                }
                else
                {
                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = city;

                    studentsList.Add(student);
                }
            }

            string filter = Console.ReadLine();

            foreach (Student student in studentsList)
            {
                if (student.homeTown == filter)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }

    
}