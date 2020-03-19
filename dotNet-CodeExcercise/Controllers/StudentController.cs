using System;
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
    }
}
