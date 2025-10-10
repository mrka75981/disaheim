using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Course
    {
        public string Name;
        public int DurationInMinutes;


        public Course(): this("", 0) {}

        public Course(string name, int durationInMinutes)
        {
            this.Name = name;
            this.DurationInMinutes = durationInMinutes;
        }
        public Course(int dur) : this("", dur) {}
        public Course(string name): this(name, 0) {}

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}
