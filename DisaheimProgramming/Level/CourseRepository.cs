using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();



        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string Name)
        {
            Course checkcourse = new Course(Name);
            foreach (Course course in courses){ 
                if (course.Name == checkcourse.Name)
                {
                    return course;
                }
            
            }

            return null;
        }

        public double GetTotalValue()
        {
            double totalvalue = 0;
            Utility utiltiy = new Utility();
            foreach (Course course in courses)
            {
                totalvalue += utiltiy.GetValueOfCourse(course);
            }
            return totalvalue;
        }
    }
}
