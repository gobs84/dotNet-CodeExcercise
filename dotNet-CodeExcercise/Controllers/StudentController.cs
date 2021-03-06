﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNet_CodeExcercise.Services.Models;
using dotNet_CodeExcercise.Services;

namespace dotNet_CodeExcercise.Controllers
{
    class StudentController
    {
        private StudentServices studentServices = new StudentServices();
        public void Post(string type,string name, string gender, DateTime timeStamp)
        {
            studentServices.CreateStudent(type,name,gender,timeStamp); 
        }

        public List<Student> GetStudentByName(string name)
        {
            return studentServices.FindStudentByName(name);
        }

        public List<Student> GetStudentByType(string type)
        {
            return studentServices.FindStudentByType(type);
        }

        public List<Student> GetStudentByGenderAndType(string type,string gender)
        {
            return studentServices.FindStudentByGenderAndType(type,gender);
        }

        public void DeleteStudent(String name)
        {
            studentServices.DeleteStudent(name);
        }
    }
}
