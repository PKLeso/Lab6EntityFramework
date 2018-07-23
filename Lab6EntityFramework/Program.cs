using Lab6EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingRepository trainingRepository = new TrainingRepository();

            Console.WriteLine("A list of courses");
            Console.WriteLine("******************");
            foreach (var item in trainingRepository.ListCourses())
            {
                Console.WriteLine(item.CourseCode +" "+ item.CourseName +" "+ item.CreatedBy);
            }

            Console.WriteLine();

            Console.WriteLine("The upcoming courses");
            Console.WriteLine("********************");
            trainingRepository.GetUpcomingCourse();

            Console.WriteLine();

            Console.WriteLine("Delegate Info");
            Console.WriteLine("********************");
            trainingRepository.GetDelegateInfo();

            Console.ReadLine();
        }


    }
}
