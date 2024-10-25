//namespace Disaheim
//{
//    public class CourseRepository
//    {
//        private List<Course> courses;

//        public void AddCourse(Course course)
//        {
//            this.courses.Add(course);
//        }
//        public Course GetCourse(string Name)
//        {
//            foreach (Course course in courses)
//            {
//                if (course.Name == Name)
//                {
//                    return course;
//                }
//            }
//            return null;
//        }

//        public double GetTotalValue()
//        {
//            double total = 0;
//            foreach (Course course in courses)
//            {
//                int hours = course.DurationInMinutes / 60;
//                total += (course.DurationInMinutes % 60 > 0) ? (hours + 1) * 875 : hours * 875;
//            }
//            return total;
//        }
//        public CourseRepository()
//        {
//            courses = new List<Course>();
//        }
//    }
//}
