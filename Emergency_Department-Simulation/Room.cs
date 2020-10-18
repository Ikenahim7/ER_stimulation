using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Department_Simulation
{
   public class Room
    {
        public Position RoomPosition;
        public const double SIZE = 50;
        public Point Location;
        public Category Category;
        public List<Bed> Beds { get; private set; }
        public List<Patient> AllPatients { get; private set; }
        public bool selected { get; set; }
        public List<Patient> CurrentPatients { get; private set; }


        public Room(Point location, Category category, Position position)
        {
            Beds = new List<Bed>();
            this.Location = location;
            this.Category = category;
            RoomPosition = position;
            AllPatients = new List<Patient>();
            CurrentPatients = new List<Patient>();

            //for testing
            //waitingRoomStartLocation = new Point(500, 0);
            //waitingRoomEndLocation = new Point(800, 800);
        }

        public void AddBeds(int nr)
        {
            Point[] bedLocations = new Point[] { new Point((int) (Location.X + SIZE / 10), (int) (Location.Y + SIZE / 10)),
                                    new Point((int) (Location.X + SIZE - SIZE / 10 - Patient.SIZE), (int) (Location.Y + SIZE / 10)),
                                    new Point((int) (Location.X + SIZE / 10), (int) (Location.Y + SIZE - SIZE / 10 - Patient.SIZE)),
                                    new Point((int) (Location.X + SIZE - SIZE / 10 - Patient.SIZE), (int) (Location.Y + SIZE - SIZE / 5 - Patient.SIZE)) };

            for(int i = 0; i < nr; i++)
            {
                // for testing
                Bed bed = new Bed(Injury.GetColor(Category), bedLocations[i], this);
                Beds.Add(bed);
            }
        }

        public Bed GetFreeBed()
        {
            return null;
        }

        public void DrawRoom(Graphics gr)
        {
            Pen myPen;
            if (!selected)
                myPen = new Pen(Color.Black);
            else
                myPen = new Pen(Color.Red); SolidBrush myBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("Arial");

            Font font = new Font(
               fontFamily,
               12,
               FontStyle.Regular,
               GraphicsUnit.Pixel);

            Rectangle myRectangle = new Rectangle(Location.X, Location.Y, Convert.ToInt32(SIZE), Convert.ToInt32(SIZE));

            if (Category == Category.A)
            {
                gr.DrawRectangle(myPen, myRectangle);
                gr.DrawString("A", font, myBrush, (Location.X + Convert.ToInt32(SIZE) / 2) - font.Size / 2 , (Location.Y + (Convert.ToInt32(SIZE) / 2)) - font.Size /2);
            }
            else if (Category == Category.B)
            {
                gr.DrawRectangle(myPen, myRectangle);
                gr.DrawString("B", font, myBrush, (Location.X + Convert.ToInt32(SIZE) / 2) - font.Size / 2, (Location.Y + Convert.ToInt32(SIZE) / 2) - font.Size / 2);
            }
            else if (Category == Category.C)
            {
                gr.DrawRectangle(myPen, myRectangle);
                gr.DrawString("C", font, myBrush, (Location.X + Convert.ToInt32(SIZE) / 2) - font.Size / 2, (Location.Y + Convert.ToInt32(SIZE) / 2) - font.Size / 2);
            }
            else if (Category == Category.D)
            {
                gr.DrawRectangle(myPen, myRectangle);
                gr.DrawString("D", font, myBrush, (Location.X + Convert.ToInt32(SIZE) / 2) - font.Size / 2, (Location.Y + Convert.ToInt32(SIZE) / 2) - font.Size / 2);
            }
        }

        public void AddPatient(Patient p)
        {
            AllPatients.Add(p);
            CurrentPatients.Add(p);
        }
    }
}
