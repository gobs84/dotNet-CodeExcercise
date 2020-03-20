using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNet_CodeExcercise.Controllers;
using dotNet_CodeExcercise.Services.Models;
namespace dotNet_CodeExcercise
{
    class Program
    {
        private StudentController studentController = new StudentController();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.CreateStudents(args[0]);
            program.PrintStudents(program.FindStudent(args));
            Console.ReadLine();
        }

        public void CreateStudents(string file)
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            using (var reader = new StreamReader(dir + $@"\{file}"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    studentController.Post(values[0], values[1], values[2], DateTime.ParseExact(values[3], "yyyyMMddHHmmss", CultureInfo.InvariantCulture));
                }
            }
        }

        public List<Student> FindStudent(string[] args)
        {
            List<Student> students = new List<Student>();
            string searchValue = args[1].Split('=')[1];
            if (args.Length > 2)
            {

            }
            else if (SearchType(args[1]))
            {
                students = studentController.GetStudentByName(searchValue);
            }
            else
            {
                students = studentController.GetStudentByType(searchValue);
            }
            return students;
        }

        public Boolean SearchType(string search)
        {
            string searchstandar = search.Split('=')[0];
            Boolean typeFlag = false;
            if (Equals(searchstandar, "name"))
            {
                typeFlag = true;
            }
            return typeFlag;
        }

        public void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Type:{student.Type}\nStudent:{student.Name}\nGender:{Gender(student.Gender)}\nTimestamp:{student.TimeStamp.ToString("dd/MM/yyyy HH:mm:ss")}\n\n");
            }
        }

        public string Gender(string gender)
        {
            string completeGender="Male";
            if (Equals(gender, "F"))
            {
                completeGender = "Female";
            }
            return completeGender;
        }
    }
}
