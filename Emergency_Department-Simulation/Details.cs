using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Department_Simulation
{
    public static class Details
    {
        public static readonly Point[] pathAB = pathAB = new Point[] { new Point(Form1.size.Width, Form1.size.Height / 8), new Point(0, Form1.size.Height / 8) };
        public static readonly Point[] pathCD = pathCD = new Point[] { new Point(Form1.size.Width, (int)(Form1.size.Height / 1.5)), new Point(0, (int)(Form1.size.Height / 1.5)) };
        public static readonly int exitSize = 25;
        public static readonly int waitingRoomWidth = 50;
        public static readonly int waitingRoomHeight = Form1.size.Height - 2 * exitSize;
        public static readonly Point waitingRoomStartLocation = new Point(Form1.size.Width - waitingRoomWidth, 0);
        public static readonly Point waitingRoomEndLocation = new Point(Form1.size.Width - 20, waitingRoomHeight - 20);
        public static readonly Point exitStartLocation = new Point(Form1.size.Width - exitSize, Form1.size.Height - exitSize);
        public static readonly Point exitEndLocation = new Point(Form1.size.Width, Form1.size.Height);

        public static readonly TimeSpan CriticalWaitingTimeA = new TimeSpan(0, 0, 30);
        public static readonly TimeSpan CriticalWaitingTimeB = new TimeSpan(0, 0, 60);
        public static readonly TimeSpan CriticalWaitingTimeC = new TimeSpan(0, 1, 0);
        public static readonly TimeSpan CriticalWaitingTimeD = new TimeSpan(0, 1, 0);
    }
}
