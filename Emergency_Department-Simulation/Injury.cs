using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Department_Simulation
{
   public class Injury
    {
        private static TimeSpan minPeriodA = new TimeSpan(0, 0, 20);
        private static TimeSpan maxPeriodA = new TimeSpan(0, 0, 25);
        private static TimeSpan minPeriodB = new TimeSpan(0, 0, 15);
        private static TimeSpan maxPeriodB = new TimeSpan(0, 0, 20);
        private static TimeSpan minPeriodC = new TimeSpan(0, 0, 10);
        private static TimeSpan maxPeriodC = new TimeSpan(0, 0, 15);
        private static TimeSpan minPeriodD = new TimeSpan(0, 0, 5);
        private static TimeSpan maxPeriodD = new TimeSpan(0, 0, 10);

        private static Color colorA = Color.Red;
        private static Color colorB = Color.Yellow;
        private static Color colorC = Color.Blue;
        private static Color colorD = Color.Green;

        public Category Category { get; private set; }

        public Injury(Category category)
        {
            Category = category;
        }

        public static TimeSpan[] GetTimeInterval(Category category)
        {
            TimeSpan[] interval = new TimeSpan[2];
            switch (category)
            {
                case Category.A:
                    interval[0] = minPeriodA;
                    interval[1] = maxPeriodA;
                        break;
                case Category.B:
                    interval[0] = minPeriodB;
                    interval[1] = maxPeriodB;
                        break;
                case Category.C:
                    interval[0] = minPeriodC;
                    interval[1] = maxPeriodC;
                    break;
                case Category.D:
                    interval[0] = minPeriodD;
                    interval[1] = maxPeriodD;
                    break;
            }

            return interval;
        }

        public static Color GetColor(Category category)
        {
            switch(category)
            {
                case Category.A:
                    return colorA;
                case Category.B:
                    return colorB;
                case Category.C:
                    return colorC;
                default:
                    return colorD;
            }
        }
    }
}
