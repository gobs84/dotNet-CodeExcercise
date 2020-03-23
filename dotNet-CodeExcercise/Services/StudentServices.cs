using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNet_CodeExcercise.Services.Models;

namespace dotNet_CodeExcercise.Services
{
    class StudentServices
    {
        public StudentsDB students;
        public StudentServices()
        {
            students = StudentsDB.Instance;
        }
        public void CreateStudent(string type, string name, string gender, DateTime timeStamp)
        {
            try
            {
                Student student = new Student
                {
                    Type = type,
                    Name = name,
                    Gender = gender,
                    TimeStamp = timeStamp
                };
                students.StudentList.Add(student);
            }
            catch (ServiceException e)
            {
                throw new ServiceException($"Couldn't create Users: {e}",500);
            }
            
        }

        public List<Student> FindStudentByName(string name)
        {
            List<Student> findStudents = new List<Student>();
            foreach (Student student in students.StudentList)
            {
                if (Equals(student.Name.ToLower(), name.ToLower()))
                {
                    findStudents.Add(student);
                }
            }
            
            return findStudents;
        }

        public List<Student> FindStudentByType(string type)
        {
            List<Student> findStudents = new List<Student>();
            foreach (Student student in students.StudentList)
            {
                if (Equals(student.Type.ToLower(), type.ToLower()))
                {
                    findStudents.Add(student);
                }
            }
            return findStudents.OrderByDescending(student => student.TimeStamp).ToList(); ;
        }

        public List<Student> FindStudentByGenderAndType(string type,string gender)
        {
            List<Student> findStudents = new List<Student>();
            foreach (Student student in students.StudentList)
            {
                if (Equals(student.Type.ToLower(), type.ToLower()) && Equals(student.Gender.ToLower(),gender.ToLower()))
                {
                    findStudents.Add(student);
                }
            }
            return findStudents.OrderByDescending(student => student.TimeStamp).ToList(); ;
        }

        public void DeleteStudent(string name)
        {
            Student student = students.StudentList.Find(x => x.Name.ToLower() == name.ToLower());
            students.StudentList.Remove(student);
        }
    }
}
