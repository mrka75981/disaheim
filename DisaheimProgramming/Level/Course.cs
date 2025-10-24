using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Course : IValuable
    {
        public string Name;
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue = 875.0;


        public Course(): this("", 0) {}

        public Course(string name, int durationInMinutes)
        {
            this.Name = name;
            this.DurationInMinutes = durationInMinutes;
        }
        public Course(int dur) : this("", dur) {}
        public Course(string name): this(name, 0) {}

        public double GetValue()
        {
            int WholeHour = DurationInMinutes / 60;
            int RemainingMinutes = DurationInMinutes % 60;

            if (RemainingMinutes > 0)
            {
                WholeHour++;
            }


            return WholeHour * CourseHourValue;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }
    }
}
