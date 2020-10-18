using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Department_Simulation
{
   public class Patient
    {
        private static int nextID;
        public const int SIZE = 15;
        public Bitmap Image { get; private set; }
        public int PatientID { get; private set; }
        public TimeSpan Timer { get; set; }
        public DateTime ArrivedTime { get; private set; }
        public DateTime TreatmentStart { get; set; }
        public Point Location { get; private set; }
        public Bed Bed { get; set; }
        public Injury Injury { get; private set; }
        public Point[] PathToFollow { get; set; }
        public Room Room { get; set; }
        public bool Managed { get; set; }
        public bool Discharged { get; set; }
        public bool Critical { get; set; }
        public DateTime LeaveTime { get; set; }
        public DateTime StartNavigate { get; set; }
        
        //for random invoked patients
       

        public Patient(DateTime arrivedTime, Point location, Injury injury, Bitmap image)
        {
            PatientID = nextID++;
            ArrivedTime = arrivedTime;
            Location = location;
            Injury = injury;
            Image = image;
        }

        public string GetInfo()
        {
            string info = "Patient " + PatientID + " Arrived at " + ArrivedTime + " and has waited for " + Timer;
            return info;
        }

        public void DrawPatient(Graphics gr)
        {
            gr.DrawImage(Image, Location);
        }

        public bool GoToRoom()
        {
            if (Location == Bed.Location)
            {
                return true;
            }

            Point pathStarting = PathToFollow[0];

            if (Location.X == Bed.Location.X)
            {
                switch (Bed.Room.RoomPosition)
                {
                    case Position.UP:
                        Location = new Point(Location.X, Location.Y - 1);
                        break;
                    case Position.DOWN:
                        Location = new Point(Location.X, Location.Y + 1);
                        break;
                }
            }
            else if(pathStarting.Y > Location.Y)
            {
                Location = new Point(Location.X, Location.Y + 1);
            }
            else if(pathStarting.Y < Location.Y)
            {
                Location = new Point(Location.X, Location.Y - 1);
            }
            else
            {
                Location = new Point(Location.X - 1, Location.Y);
            }

            return false;

        }
    }
}
