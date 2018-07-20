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

        public List<Course> GetCoursesWithUpComingTraining()
        {
            //TODO:
            return TrainingDBContext.Courses.ToList();
        }

        public List<Registration> GetRegisteredDelegates()
        {

            return TrainingDBContext.Registrations.ToList();
        }
    }
}
