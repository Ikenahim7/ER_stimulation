using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Emergency_Department_Simulation.Properties;
using System.Windows.Forms;

namespace Emergency_Department_Simulation
{
   public class Simulation
    {
        public Object allPatientsLock { get; private set; }
        public Object roomPatientsLock { get; private set; }
        public Object patientsToNavigateLock { get; private set; }
        //private Object patientsToExitLock;
        private bool randomPatients;
        public bool Running { get;  private set; }

        Random rnd;
        public List<Thread> Threads { get; private set; }
        Thread dischargePatientsThread;
        Thread managePatientsThread;
        Thread randomPatientsThread;

        public List<Patient> AllPatients { get; private set; }
        public List<Patient> RoomPatients { get; private set; }
        public List<Patient> DataPatients { get; private set; }
       
        public List<Patient> PatientsA { get; private set; }
        public List<Patient> PatientsB { get; private set; }
        public List<Patient> PatientsC { get; private set; }
        public List<Patient> PatientsD { get; private set; }
        public List<Room> Rooms { get; private set; }
        public List<Patient> PatientsToNavigate { get; private set; }
        //public List<Patient> PatientsToExit { get; private set; }
        public int LimitA { get; private set; }
        public int LimitB { get; private set; }
        public int LimitC { get; private set; }
        public int LimitD { get; private set; }
        public DateTime StartTime { get; set; }

        //for testing
        public Simulation()
        {
            allPatientsLock = new object();
            roomPatientsLock = new object();
            patientsToNavigateLock = new object();
            //patientsToExitLock = new object();
            rnd = new Random();
            Threads = new List<Thread>();
            AllPatients = new List<Patient>();
            RoomPatients = new List<Patient>();
            PatientsA = new List<Patient>();
            PatientsB = new List<Patient>();
            PatientsC = new List<Patient>();
            PatientsD = new List<Patient>();
            Rooms = new List<Room>();
            PatientsToNavigate = new List<Patient>();
            DataPatients = new List<Patient>();
            //PatientsToExit = new List<Patient>();
        }

        public bool RandomPatients
        {
            get
            {
                return randomPatients;
            }
            set
            {
                if (value == true)
                {
                    randomPatientsThread = new Thread(AddPatientsRandomly);
                    randomPatientsThread.Start();
                }

                randomPatients = value;
            }
        }

        public void AddPatients(int nr, Category category)
        {
            for(int i = 0; i < nr; i++)
            {
                int x = rnd.Next(Details.waitingRoomStartLocation.X, Details.waitingRoomEndLocation.X);
                int y = rnd.Next(Details.waitingRoomStartLocation.Y, Details.waitingRoomEndLocation.Y);
                Point point = new Point(x, y);

                Injury injury = new Injury(category);
                Bitmap image;

                switch (category)
                {
                    case Category.A:
                        image = new Bitmap(Resources.a, Patient.SIZE, Patient.SIZE);
                        break;
                    case Category.B:
                        image = new Bitmap(Resources.b, Patient.SIZE, Patient.SIZE);
                        break;
                    case Category.C:
                        image = new Bitmap(Resources.c, Patient.SIZE, Patient.SIZE);
                        break;
                    default:
                        image = new Bitmap(Resources.d, Patient.SIZE, Patient.SIZE);
                        break;
                }

                Patient p = new Patient(DateTime.Now, point, injury, image);

                lock (allPatientsLock)
                {
                    AllPatients.Add(p);
                    
                }

                lock(DataPatients)
                {
                    DataPatients.Add(p);
                }

                AddPatientToWaitingList(p);
            }
        }

       

        public void AddPatients(int nr)
        {
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            for(int i = 0; i < nr; i++)
            {

                //int categoryIndex = rnd.Next(1, 5);         //generate number between 1,2,3,4
                int oi = rnd.Next(1, 22);
                int categoryIndex = Convert.ToInt32(System.Math.Pow(oi, 0.5));

                switch (categoryIndex)
                {
                    case 1:
                        countA++;
                        break;
                    case 2:
                        countB++;
                        break;
                    case 3:
                        countC++;
                        break;
                    case 4:
                        countD++;
                        break;
                }
            }

            AddPatients(countA, Category.A);
            AddPatients(countB, Category.B);
            AddPatients(countC, Category.C);
            AddPatients(countD, Category.D);
        }

    
        private void AddPatientToWaitingList(Patient p)
        {
            Category category = p.Injury.Category;

            switch(category)
            {
                case Category.A:
                    PatientsA.Add(p);
                    break;
                case Category.B:
                    PatientsB.Add(p);
                    break;
                case Category.C:
                    PatientsC.Add(p);
                    break;
                case Category.D:
                    PatientsD.Add(p);
                    break;
            }
        }

        public int GetCritical()
        {
            List<Patient> patientsToRemove = new List<Patient>();

            lock(allPatientsLock)
            {
                foreach (Patient p in AllPatients)
                {
                    if (DateTime.Now - p.ArrivedTime > Details.CriticalWaitingTimeA && p.Injury.Category == Category.A)
                    {
                        patientsToRemove.Add(p);
                        p.Critical = true;
                    }
                    else if (DateTime.Now - p.ArrivedTime > Details.CriticalWaitingTimeB && p.Injury.Category == Category.B)
                    {
                        patientsToRemove.Add(p);
                        p.Critical = true;
                    }
                    else if (DateTime.Now - p.ArrivedTime > Details.CriticalWaitingTimeB && p.Injury.Category == Category.C)
                    {
                        patientsToRemove.Add(p);
                        p.Critical = true;
                    }
                    else if (DateTime.Now - p.ArrivedTime > Details.CriticalWaitingTimeB && p.Injury.Category == Category.D)
                    {
                        patientsToRemove.Add(p);
                        p.Critical = true;
                    }
                }
            }

            foreach (Patient p in patientsToRemove)
            {
                lock(allPatientsLock)
                {
                    AllPatients.Remove(p);
                }

                PatientsA.Remove(p);
                PatientsB.Remove(p);
                PatientsC.Remove(p);
                PatientsD.Remove(p);
            }

            return patientsToRemove.Count;
        }


        public void AddRoomsAndBeds(int[] a, int[] b, int[] c, int[] d) //index 0 = number of rooms; index 1 = number of beds per category
        {
            Point p1 = new Point();
            p1.X = (int) Room.SIZE;
            p1.Y = Form1.size.Height / 4;

            for (int _a = 0; _a < a[0]; _a++)
            {
                int x = p1.X * _a;
                int y = p1.Y * 0;
                Point location = new Point(x, y);
                Position roomPosition = Position.UP;

                if(y > Details.pathAB[0].Y)
                {
                    roomPosition = Position.DOWN;
                }

                Room rA = new Room(location, Category.A, roomPosition);
                rA.AddBeds(a[1]);
                Rooms.Add(rA);
            }

            for (int _b = 0; _b < b[0]; _b++)
            {
                int x = p1.X * _b;
                int y = p1.Y * 1;
                Point location = new Point(x, y);
                Position roomPosition = Position.UP;

                if (y > Details.pathAB[0].Y)
                {
                    roomPosition = Position.DOWN;
                }

                Room rB = new Room(location, Category.B, roomPosition);
                rB.AddBeds(b[1]);
                Rooms.Add(rB);
            }

            for (int _c = 0; _c < c[0]; _c++)
            {
                int x = p1.X * _c;
                int y = p1.Y * 2;
                Point location = new Point(x, y);
                Position roomPosition = Position.UP;

                if (p1.Y > Details.pathCD[0].Y)
                {
                    roomPosition = Position.DOWN;
                }

                Room rC = new Room(location, Category.C, roomPosition);
                rC.AddBeds(c[1]);
                Rooms.Add(rC);
            }

            for (int _d = 0; _d < d[0]; _d++)
            {
                int x = p1.X * _d;
                int y = p1.Y * 3;
                Point location = new Point(x, y);
                Position roomPosition = Position.UP;

                if (y > Details.pathCD[0].Y)
                {
                    roomPosition = Position.DOWN;
                }

                Room rD = new Room(location, Category.D, roomPosition);
                rD.AddBeds(d[1]);
                Rooms.Add(rD);
            }
        }

        public void Start()
        {
            Running = true;
            StartTime = DateTime.Now;

            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            foreach(Room room in Rooms)
            {
                Category category = room.Category;

                switch(category)
                {
                    case Category.A:
                        countA++;
                        break;
                    case Category.B:
                        countB++;
                        break;
                    case Category.C:
                        countC++;
                        break;
                    case Category.D:
                        countD++;
                        break;
                }
            }

            LimitA = countA;
            LimitB = countB;
            LimitC = countC;
            LimitD = countD;

            managePatientsThread = new Thread(ManagePatients);
            //Thread navigatePatientsThread = new Thread(NavigatePatients);
            dischargePatientsThread = new Thread(DischargePatients);
            //Thread navigateToExit = new Thread(NavigateToExit);

            Threads.Add(managePatientsThread);
            //Threads.Add(navigatePatientsThread);
            Threads.Add(dischargePatientsThread);

            managePatientsThread.Start();
            //navigatePatientsThread.Start();
            dischargePatientsThread.Start();
            //navigateToExit.Start();
        }

        public void ManagePatients()
        {

            while (Running)
            {
                List<Patient> patients = new List<Patient>();
                patients.AddRange(TakeNextQueue());

                foreach (Patient p in patients)
                {
                    Bed bed = FindBed(p);

                    if (bed != null)
                    {
                        bed.Busy = true;
                        p.Bed = bed;
                        p.Room = bed.Room;
                        GivePatientAPath(p);

                        lock(patientsToNavigateLock)
                        {
                            PatientsToNavigate.Add(p);
                        }

                        RemoveWaitingPatient(p);
                    }
                }

                Thread.Sleep(5000);         //sleep 5 seconds
            }
        }

        private void RemoveWaitingPatient(Patient patient)
        {
            Category category = patient.Injury.Category;
            switch(category)
            {
                case Category.A:
                    PatientsA.Remove(patient);
                    break;
                case Category.B:
                    PatientsB.Remove(patient);
                    break;
                case Category.C:
                    PatientsC.Remove(patient);
                    break;
                case Category.D:
                    PatientsD.Remove(patient);
                    break;
            }
        }

        public List<Patient> TakeNextQueue()
        {
            List<Patient> patients = new List<Patient>();

            for(int i = 0; i < LimitA && i < PatientsA.Count; i++)
            {
                patients.Add(PatientsA[i]);
            }

            for (int i = 0; i < LimitB && i < PatientsB.Count; i++)
            {
                patients.Add(PatientsB[i]);
            }

            for (int i = 0; i < LimitC && i < PatientsC.Count; i++)
            {
                patients.Add(PatientsC[i]);
            }

            for (int i = 0; i < LimitD && i < PatientsD.Count; i++)
            {
                patients.Add(PatientsD[i]);
            }

            return patients;
        }

        private Bed FindBed(Patient p)
        {
            Category category = p.Injury.Category;

            foreach(Room room in Rooms)
            {
                if(room.Category == category)
                {
                    foreach(Bed bed in room.Beds)
                    {
                        if(!bed.Busy)
                        {
                            return bed;
                        }
                    }
                }
            }

            return null;
        }

        public void NavigatePatients()
        {
            List<Patient> patientsToRemove = new List<Patient>();

            lock (patientsToNavigateLock)
            {
                foreach (Patient p in PatientsToNavigate)
                {
                    if (p.GoToRoom())
                    {
                        Treat(p);
                        patientsToRemove.Add(p);
                        p.StartNavigate = DateTime.Now;
                    }
                }

                foreach (Patient p in patientsToRemove)
                {

                    PatientsToNavigate.Remove(p);
                }
            }
        }

        private void GivePatientAPath(Patient p)
        {
            switch (p.Injury.Category)
            {
                case Category.A:
                case Category.B:
                    p.PathToFollow = Details.pathAB;
                    break;
                case Category.C:
                case Category.D:
                    p.PathToFollow = Details.pathCD;
                    break;
            }
        }

        private void Treat(Patient p)
        {
            Category category = p.Injury.Category;

            TimeSpan[] interval = Injury.GetTimeInterval(category);     //index 0 = min     index 1 = max
            int seconds = rnd.Next(interval[0].Seconds, interval[1].Seconds + 1);
            p.Timer = new TimeSpan(0, 0, seconds);
            p.TreatmentStart = DateTime.Now;

            lock(roomPatientsLock)
            {
                RoomPatients.Add(p);
                p.Room.AddPatient(p);
                p.Managed = true;
            }
        }

        public void DischargePatients()
        {
            while(Running)
            {
                List<Patient> patientsToRemove = new List<Patient>();

                lock (roomPatientsLock)
                {
                    foreach (Patient p in RoomPatients)
                    {
                        TimeSpan timeSpent = DateTime.Now - p.TreatmentStart;

                        if (timeSpent > p.Timer)
                        {
                            patientsToRemove.Add(p);
                            p.Discharged = true;
                            p.LeaveTime = DateTime.Now;
                            //lock (patientsToExitLock)
                            //{
                            //    PatientsToExit.Add(p);
                            //}
                        }
                    }

                    foreach(Patient p in patientsToRemove)
                    {
                        p.Bed.Busy = false;
                        RoomPatients.Remove(p);
                        p.Room.CurrentPatients.Remove(p);

                        lock (allPatientsLock)
                        {
                            AllPatients.Remove(p);
                        }
                    }
                }
            }
        }

        //private void NavigateToExit()
        //{
        //    while(Running)
        //    {
        //        lock(patientsToExitLock)
        //        {
        //            List<Patient> patientsToRemove = new List<Patient>();

        //            foreach (Patient p in PatientsToExit)
        //            {
        //                if (p.GoToExit())
        //                {
        //                    lock(allPatientsLock)
        //                    {
        //                        AllPatients.Remove(p);
        //                    }
        //                    patientsToRemove.Add(p);
        //                }
        //            }

        //            foreach (Patient p in patientsToRemove)
        //            {
        //                PatientsToExit.Remove(p);
        //            }
        //        }

        //        Thread.Sleep(10);
        //    }
        //}
        public void Stop()
        {
            Running = false;
        }

        public void Draw(Graphics gr)
        {
            foreach(Room r in Rooms)
            {
                r.DrawRoom(gr);
            }

            lock(allPatientsLock)
            {
                foreach (Patient p in AllPatients)
                {
                    p.DrawPatient(gr);
                }
            }
        }

        private void AddPatientsRandomly()
        {
            while(randomPatients && Running)
            {
                int nr;
                int rndNr = rnd.Next(0, 26);

                if (rndNr >= 25)
                {
                    nr = rnd.Next(0, 150);
                }
                else if (rndNr >= 23)
                {
                    nr = rnd.Next(0, 120);
                }
                else if (rndNr >= 18)
                {
                    nr = rnd.Next(0, 80);
                }
                else if (rndNr >= 10)
                {
                    nr = rnd.Next(1, 30);
                }
                else
                {
                    nr = rnd.Next(1, 10);
                }

                AddPatients(nr);
                Thread.Sleep(10000);
            }
        }
    }
}
