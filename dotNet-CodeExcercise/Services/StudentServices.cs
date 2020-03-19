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
            Student student = new Student
            {
                Type = type,
                Name = name,
                Gender = gender,
                TimeStamp = timeStamp
            };
            students.StudentList.Add(student);
        }

        
    }
}
