using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6EntityFramework.Models
{
    class TrainingRepository
    {
        // Use this Repository for all kinds of methods when interacting with the Database
        // Use Generic types
        // Use Linq

        TrainingDBContext TrainingDBContext = new TrainingDBContext();

        public List<Training> GetTrainings()
        {
            return TrainingDBContext.Trainings.ToList();
        }
        public List<Course> GetCourses()
        {
            return TrainingDBContext.Courses.ToList();
        }
        public List<Registration> GetRegistrations()
        {
            return TrainingDBContext.Registrations.ToList();
        }
        

        public List<Delegate> GetDelegates()
        {
            return TrainingDBContext.Delegates.ToList();
        }

        public List<Course> ListCourses()
        {
            DateTime Currentdate = DateTime.Now;

            var courses = from course in TrainingDBContext.Courses
                                 select course;

            return courses.ToList();
        }

        public void GetUpcomingCourse()
        {
            DateTime Currentdate = DateTime.Now;

            var innerJoinQuery = from course in TrainingDBContext.Courses
                                 join training in TrainingDBContext.Trainings on course.CourseID equals training.CourseID
                                 where training.StartDate > Currentdate
                                 select course;

            foreach (var item in innerJoinQuery)
            {
                Console.WriteLine(item.CourseID + " " + item.CourseCode + " " + item.CourseName + " " + item.CourseDescription + " " + item.Training);
                break; // To only display once
            }
        }

        public void GetDelegateInfo()
        {
            DateTime Currentdate = DateTime.Now;

            var delegateQuery = from Delegate in TrainingDBContext.Delegates
                                join Dietary in TrainingDBContext.Dietaries on Delegate.DietaryID equals Dietary.DietaryID
                                select new { Delegate, Dietary };

            foreach (var item in delegateQuery)
            {
                Console.WriteLine(item.Delegate.FirstName + " " + item.Delegate.LastName + " " + item.Dietary.Description);
            }
        }
        

        // For Testing purposes
        //public void AddDelegate(string FName, string LName, string Email, string phoneNr, string CompanyName)
        //{
        //    Delegate @delegate = new Delegate
        //    {
        //        FirstName = FName,
        //        LastName = LName,
        //        Email = Email,
        //        PhoneNumber = phoneNr,
        //        CompanyName = CompanyName
        //    };
        //    TrainingDBContext.Delegates.Add(@delegate);
        //    TrainingDBContext.SaveChanges();
        //}
    }
}
