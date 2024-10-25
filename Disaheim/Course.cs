namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue { get; set; } = 875.0;

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, int durationInMinutes)
        {
            this.Name = name;
            this.DurationInMinutes = durationInMinutes;
        }

        public double GetValue()
        {
            double total = 0;
            int hours = DurationInMinutes / 60;
            total += (DurationInMinutes % 60 > 0) ? (hours + 1) * CourseHourValue : hours * CourseHourValue;
            return total;
        } 
        public override string ToString()
        {
            double value = GetValue();
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {value}";
        }
    }
}
