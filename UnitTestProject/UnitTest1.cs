using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emergency_Department_Simulation;
using System.Drawing;
using System.Threading;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddPatients()
        {
            Simulation s = new Simulation();

            s.AddPatients(10);
            Assert.AreEqual(s.AllPatients.Count, 10);
        }

        [TestMethod]

        public void AddRoomsAndBeds()
        {
            Simulation s = new Simulation();
            s.AddRoomsAndBeds(new int[] { 5, 2 }, new int[] { 2, 2 }, new int[] { 6, 2 }, new int[] { 4, 2 });

            Assert.AreEqual(s.Rooms.Count, 17);
        }

        [TestMethod]

        public void Start()
        {
            Simulation s = new Simulation();
          //  s.AddPatient(10);
            s.AddRoomsAndBeds(new int[] { 5, 2 }, new int[] { 2, 2 }, new int[] { 6, 2 }, new int[] { 4, 2 });
            s.Start();

            Assert.AreEqual(s.LimitA, 5);
            Assert.AreEqual(s.LimitB, 2);
            Assert.AreEqual(s.LimitC, 6);
            Assert.AreEqual(s.LimitD, 4);
        }

        [TestMethod]

        public void ManagePatients()
        {
            Simulation s = new Simulation();
            s.AddRoomsAndBeds(new int[] { 5, 2 }, new int[] { 2, 2 }, new int[] { 6, 2 }, new int[] { 4, 2 });
            s.AddPatients(10);
            s.Start();
            Assert.AreNotEqual(s.PatientsToNavigate, 0);

            foreach(Patient p in s.PatientsToNavigate)
            {
                Assert.AreNotEqual(p.Bed, null);
                Assert.AreEqual(p.Bed.Busy, true);
            }

            s.Running = false;
        }









    }
}
