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
            Console.WriteLine("Hello");
            Program program = new Program();
            program.CreateStudents(args[0]);
            Console.ReadLine();
        }

        public void CreateStudents(string file)
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            using (var reader = new StreamReader(dir+@"\input.csv"))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    studentController.Post(values[0],values[1],values[2], DateTime.ParseExact(values[3], "yyyyMMddHHmmss", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
