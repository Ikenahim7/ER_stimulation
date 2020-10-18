using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Department_Simulation
{
   public class Bed
    {
        public bool Busy { get; set; }
        public Color Color { get; private set; }
        public Point Location { get; private set; }
        public Room Room { get; private set; }

        public Bed(Color color, Point location, Room room)
        {
            Color = color;
            Location = location;
            Room = room;
        }
    }
}
