namespace Disaheim
{
    public class Utility
    {
        public double LowQualityValue { get; set; }

        public double MediumQualityVlaue { get; set; }

        public double HighQualityValue { get; set; }

        public double CourseHourValue { get; set; }

        public Utility()
        {
            LowQualityValue = 12.5;
            MediumQualityVlaue = 20.0;
            HighQualityValue = 27.5;
            CourseHourValue = 875.0;
        }
        public static double GetValueOfMerchandise(Merchandise merchandise)
        {

            double total = 0;
            if (merchandise is Amulet amulet) {

                if (amulet.Quality == Level.low)
                {
                    total += 12.5;
                }
                else if (amulet.Quality == Level.medium)
                {
                    total += 20.0;
                }
                else
                {
                    total += 27.5;
                }
            }
            else if (merchandise is Book book)
            {
                total += book.Price;
            }
            return total;
        } 
        public double GetValueOfBook (Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet (Amulet amulet)
        {
            if (amulet.Quality == Level.low)
            {
                return 12.5;
            }
            else if (amulet.Quality == Level.medium)
            {
                return 20.0;
            }
            else
            {
                return 27.5;
            }
        }
        public double GetValueOfCourse(Course course)
        {
            int hours = course.DurationInMinutes / 60;
            return (course.DurationInMinutes % 60 > 0) ? (hours + 1) * 875 : hours * 875;
        }
    }
}
