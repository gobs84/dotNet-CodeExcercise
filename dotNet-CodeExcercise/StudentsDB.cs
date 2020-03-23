using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNet_CodeExcercise.Services.Models;

namespace dotNet_CodeExcercise
{
    class StudentsDB
    {
        private static StudentsDB _instance;

        private StudentsDB()
        {
            Initiate();
        }

        private void Initiate()
        {
            this.StudentList = new List<Student>();
        }

        public static StudentsDB Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StudentsDB();
                }
                return _instance;
            }
        }


        public List<Student> StudentList { get; private set; }
    }
}
