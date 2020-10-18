using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Emergency_Department_Simulation
{
    class TimeSimulation
    {
        public double totalGameSeconds { get; private set; }
        public double seconds { get; private set; }
        public double minutes { get; private set; }
        public double hours { get; private set; }
        public double days { get; private set; }
        public double months { get; private set; }
        public double years { get; private set; }
        private double secondsPerSecond { get;  set; }

       public void Start()
        {

            secondsPerSecond = 1;
            //totalGameSeconds += secondsPerSecond * Time.deltaTime;

        }

        public DateTime Clock()
        {
            return DateTime.Now;
        }


    }
}
