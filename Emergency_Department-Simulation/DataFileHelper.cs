using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Emergency_Department_Simulation
{
    class DataFileHelper
    {

        private string fileName;
        private Simulation sim;
        private object[] DataA = new object[8];
        private object[] DataB = new object[8];
        private object[] DataC = new object[8];
        private object[] DataD = new object[8];

        private object[] RecomandationsA = new object[1];
        private object[] RecomandationsB = new object[1];
        private object[] RecomandationsC = new object[1];
        private object[] RecomandationsD = new object[1];

        public string FileName
        {

            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }

        public int GetNrOfAllPatients()
        {
            return sim.DataPatients.Count;
        }

        public int GetNrOfCurentPatients()
        {
            return sim.AllPatients.Count;
        }

        public int GetNrOfCurentPatients(Category c)
        {
            int count = 0;

            foreach (Patient p in sim.AllPatients)
            {
                if (p.Injury.Category == c)
                {
                    count++;
                }
            }

            return count;
        }

        public double GetAverageWaitingTime()
        {
            double avgA = GetAverageWaitingTime(Category.A);
            double avgB = GetAverageWaitingTime(Category.B);
            double avgC = GetAverageWaitingTime(Category.C);
            double avgD = GetAverageWaitingTime(Category.D);

            double sum = avgA + avgB + avgC + avgD;
            return Math.Round(sum / 4, 2);
        }

        public double GetAverageTreatTime()
        {
            double avgA = GetAverageTreatTime(Category.A);
            double avgB = GetAverageTreatTime(Category.B);
            double avgC = GetAverageTreatTime(Category.C);
            double avgD = GetAverageTreatTime(Category.D);

            double sum = avgA + avgB + avgC + avgD;
            return Math.Round(sum / 4, 2);
        }

        public DataFileHelper(string _fileName, Simulation sim)
        {
            this.FileName = _fileName;
            this.sim = sim;
        }
        public DataFileHelper()
        {
            this.FileName = null;
        }
        public int TreatedPatients(Category cat)
        {
            int count = 0;
            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    if (p.Injury.Category == cat && p.Discharged == true)
                    {
                        count++;

                    }
                }
            }
            return count;
        }

        public int TotalNumberOfDeathPatients()
        {
            int count = 0;
            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    if (p.Critical == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public int NumberOfDeathPatientPerCat(Category Cat)
        {
            int count = 0;
            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    if (p.Injury.Category == Cat && p.Critical == true)
                    {
                        count++;


                    }
                }
            }
            return count;
        }

        public double GetAverageWaitingTime(Category cat)
        {
            int count = 0;
            TimeSpan dataTime = TimeSpan.Zero;

            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    if (p.Injury.Category == cat)
                    {
                        count++;

                        if (p.Managed == true)
                        {
                            dataTime += p.TreatmentStart.Subtract(p.ArrivedTime);
                        }
                        else if(!p.Critical)
                        {
                            dataTime += DateTime.Now.Subtract(p.ArrivedTime);
                        }
                    }
                }
            }

            return Math.Round(dataTime.TotalSeconds / count, 2);

        }

        public int GetNrOfAllPatients(Category cat)
        {
            int count = 0;

            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    if (p.Injury.Category == cat)
                    {
                        count++;

                    }
                }
            }
            return count;
        }
        public int GetNrOfLeftPatients(Category cat)
        {
            int counter = 0;
            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    if (p.Injury.Category == cat)
                    {
                        counter++;

                    }
                }
            }

            return counter;
        }

        public int GetNrOfLeftPatients()
        {
            int countA = GetNrOfLeftPatients(Category.A);
            int countB = GetNrOfLeftPatients(Category.B);
            int countC = GetNrOfLeftPatients(Category.C);
            int countD = GetNrOfLeftPatients(Category.D);

            int sum = countA + countB + countC + countD;

            return sum;
        }

        public int GetNrOfPatientsInRoom()
        {
            return sim.RoomPatients.Count;
        }

        public int GetNrOfPatientsInRoom(Category c)
        {
            int count = 0;

            foreach (Patient p in sim.RoomPatients)
            {
                if (p.Injury.Category == c)
                {
                    count++;
                }
            }

            return count;
        }

        public int NumberOfRoomsPerCat(Category cat)
        {
            int rooms = 0;
            foreach (Room r in sim.Rooms)
            {
                if (r.Category == cat)
                {
                    rooms += r.Beds.Count();
                    if (cat == Category.A)
                    {
                        DataA[2] = rooms + " rooms," + NumberOfbed(Category.A) + " beds";
                    }
                    if (cat == Category.B)
                    {
                        DataB[2] = rooms + " rooms," + NumberOfbed(Category.B) + " beds";
                    }
                    if (cat == Category.C)
                    {
                        DataC[2] = rooms + " rooms," + NumberOfbed(Category.C) + " beds";
                    }
                    if (cat == Category.D)
                    {
                        DataD[2] = rooms + " rooms," + NumberOfbed(Category.D) + " beds";
                    }

                }
            }
            return rooms;

        }
        public int[] GetNrOfWaitingPatientsPerCategory()
        {
            int[] Data = new int[4];
            Data[0] = sim.LimitA;
            Data[1] = sim.LimitB;
            Data[2] = sim.LimitC;
            Data[3] = sim.LimitD;

            return Data;
        }

        public int GerNrOfWaitingPatients(Category c)
        {
            switch (c)
            {
                case Category.A:
                    return sim.PatientsA.Count;
                case Category.B:
                    return sim.PatientsB.Count;
                case Category.C:
                    return sim.PatientsC.Count;
                default:
                    return sim.PatientsD.Count;
            }
        }

        public int GerNrOfWaitingPatients()
        {
            int countA = GerNrOfWaitingPatients(Category.A);
            int countB = GerNrOfWaitingPatients(Category.B);
            int countC = GerNrOfWaitingPatients(Category.C);
            int countD = GerNrOfWaitingPatients(Category.D);

            int sum = countA + countB + countC + countD;

            return sum;
        }

        public double GetAverageTreatTime(Category cat)
        {
            int count = 0;
            TimeSpan dataTime = TimeSpan.Zero;

            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    if (p.Injury.Category == cat)
                    {
                        count++;

                        if (p.Discharged == true)
                        {
                            dataTime += p.LeaveTime.Subtract(p.TreatmentStart);
                        }
                        else if (p.Managed)
                        {
                            dataTime += DateTime.Now.Subtract(p.TreatmentStart);
                        }
                    }
                }
            }

            return Math.Round(dataTime.TotalSeconds / count, 2);
        }

        public double AvgWalkingTime(Category Cat)
        {
            TimeSpan DataTime = TimeSpan.Zero;
            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    if (p.Managed == true)
                    {
                        if (p.Injury.Category == Cat)
                        {
                            DataTime += p.StartNavigate.Subtract(p.TreatmentStart);
                        }
                    }
                }
            }
            return DataTime.TotalSeconds / GetNrOfAllPatients(Cat);


        }

        public int NumberOfbed(Category P)
        {
            int Beds = 0;
            foreach (Room r in sim.Rooms)
            {
                if (r.Category == P)
                {
                    Beds += r.Beds.Count();

                }
            }
            return Beds;
        }

        public double MaxPatientsfor24h(Category p)
        {
            double max = (1440 / GetAverageTreatTime(p) + AvgWalkingTime(p)) * NumberOfbed(p);

            return max;

        }

        public void Recomandation()
        {
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            lock(sim.DataPatients)
            {
                foreach (Patient p in sim.DataPatients)
                {
                    switch (p.Injury.Category)
                    {
                        case Category.A:
                            if (p.Critical == true)
                                countA++;
                            break;
                        case Category.B:
                            if (p.Critical == true)
                                countB++;
                            break;
                        case Category.C:
                            if (p.Critical == true)
                                countC++;
                            break;
                        case Category.D:
                            if (p.Critical == true)
                                countD++;
                            break;
                    }
                }
            }
            if (countA > 0)
            {

                RecomandationsA[0] = "We suggest that you need more rooms with beds for category A.";
            }
            if (countB > 0)
            {

                RecomandationsA[0] = "We suggest that you need more rooms with beds for category B.";
            }
            if (countC > 0)
            {

                RecomandationsA[0] = "We suggest that you need more rooms with beds for category C.";
            }
            if (countD > 0)
            {
                RecomandationsA[0] = "We suggest that you need more rooms with beds for category D.";
            }
        }

        // to pass values to table in the pdf report 
        public void SetDataForPpdFile()
        {


            DataA[0] = "Category A ";
            DataA[1] = GetNrOfAllPatients(Category.A);
            DataA[3] = GetAverageWaitingTime(Category.A);
            DataA[4] = GetNrOfLeftPatients(Category.A);
            DataA[5] = NumberOfDeathPatientPerCat(Category.A);
            DataA[6] = GetAverageTreatTime(Category.A);
            DataA[7] = Math.Round(MaxPatientsfor24h(Category.A));

            DataB[0] = "Category B ";
            DataB[1] = GetNrOfAllPatients(Category.B);
            DataB[3] = GetAverageWaitingTime(Category.B);
            DataB[4] = GetNrOfLeftPatients(Category.B);
            DataB[5] = NumberOfDeathPatientPerCat(Category.B);
            DataB[6] = GetAverageTreatTime(Category.B);
            DataB[7] = Math.Round(MaxPatientsfor24h(Category.B));

            DataC[0] = "Category C ";
            DataC[1] = GetNrOfAllPatients(Category.C);
            DataC[3] = GetAverageWaitingTime(Category.C);
            DataC[4] = GetNrOfLeftPatients(Category.C);
            DataC[5] = NumberOfDeathPatientPerCat(Category.C);
            DataC[6] = GetAverageTreatTime(Category.C);
            DataC[7] = Math.Round(MaxPatientsfor24h(Category.C));

            DataD[0] = "Category D ";
            DataD[1] = GetNrOfAllPatients(Category.D);
            DataD[3] = GetAverageWaitingTime(Category.D);
            DataD[4] = GetNrOfLeftPatients(Category.D);
            DataD[5] = NumberOfDeathPatientPerCat(Category.D);
            DataD[6] = GetAverageTreatTime(Category.D);
            DataD[7] = Math.Round(MaxPatientsfor24h(Category.D));

            if (RecomandationsA[0] == null )
            {
                RecomandationsA[0] = "Nothing to display!";
            }

            if (RecomandationsB[0] == null)
            {
                RecomandationsB[0] = "Nothing to display!";
            }

            if (RecomandationsC[0] == null)
            {
                RecomandationsC[0] = "Nothing to display!";
            }

            if (RecomandationsD[0] == null)
            {
                RecomandationsD[0] = "Nothing to display!";
            }

        }

       

        // save to text file for testing data 
        public void SaveToFile()
        {
            FileStream fs;
            StreamWriter sw;
            Recomandation();

            string SimulationInfo = "This simulation was runing on date: " + sim.StartTime;
            string NumberOfPatients = "\r\n" + "Total Number of patients is: " + sim.DataPatients.Count();
            string NumberOfRooms = "\r\n" + "Number of rooms % beds per category : " + "\r\n" + "Category A: " + NumberOfRoomsPerCat(Category.A) + " rooms, " + NumberOfbed(Category.A) + " beds" + "\r\n" + "Category B: " + NumberOfRoomsPerCat(Category.B) + " rooms, " + NumberOfbed(Category.B) + " beds" + "\r\n" + "Category C: " + NumberOfRoomsPerCat(Category.C) + " rooms, " + NumberOfbed(Category.C) + " beds" + "\r\n" + "Category D: " + NumberOfRoomsPerCat(Category.D) + " rooms, " + NumberOfbed(Category.D) + " beds";
            string NumberPerCategory = "\r\n" + "Number of patient per Category : " + "\r\n" + "Category A: " + GetNrOfAllPatients(Category.A) + " , Average waiting time: " + (Math.Round(GetAverageWaitingTime(Category.A), 2)).ToString() +
                                                                                      "\r\n" + "Category B: " + GetNrOfAllPatients(Category.B) + " , Average waiting time: " + (Math.Round(GetAverageWaitingTime(Category.B), 2)).ToString() +
                                                                                       "\r\n" + "Category C: " + GetNrOfAllPatients(Category.C) + " , Average waiting time: " + (Math.Round(GetAverageWaitingTime(Category.C), 2)).ToString() +
                                                                                       "\r\n" + "Category D: " + GetNrOfAllPatients(Category.D) + " , Average waiting time: " + (Math.Round(GetAverageWaitingTime(Category.D), 2)).ToString();

            string Waitingpatients = "\r\n" + "Number of waiting patients per category : " + "\r\n" + "Category A: " + GetNrOfWaitingPatientsPerCategory()[0] + "\r\n" + "Category B: " + GetNrOfWaitingPatientsPerCategory()[1] + "\r\n" + "Category C: " + GetNrOfWaitingPatientsPerCategory()[2] + "\r\n" + "Category D: " + GetNrOfWaitingPatientsPerCategory()[3];
            string NumberOfDisPatPetCat = "\r\n" + "Number of discharge patients per category : " + "\r\n" + "Category A: " + GetNrOfLeftPatients(Category.A) + "\r\n" + "Category B: " + GetNrOfLeftPatients(Category.B) + "\r\n" + "Category C: " + GetNrOfLeftPatients(Category.C) + "\r\n" + "Category D: " + GetNrOfLeftPatients(Category.D);


            string AvgTreatTimeinfo = "\r\n" + "Average treat time per category: " + "\r\n" + "Category A: " + (Math.Round(GetAverageTreatTime(Category.A), 2)).ToString() +
                                                                                     "\r\n" + "Category B: " + (Math.Round(GetAverageTreatTime(Category.B), 2)).ToString() +
                                                                                      "\r\n" + "Category C: " + (Math.Round(GetAverageTreatTime(Category.C), 2)).ToString() +
                                                                                      "\r\n" + "Category D: " + (Math.Round(GetAverageTreatTime(Category.D), 2)).ToString();

            string AvgWalkingTimeInfo = "\r\n" + "Average walking time per category: " + "\r\n" + "Category A: " + (Math.Round(AvgWalkingTime(Category.A), 2)).ToString() +
                                                                                   "\r\n" + "Category B: " + (Math.Round(AvgWalkingTime(Category.B), 2)).ToString() +
                                                                                    "\r\n" + "Category C: " + (Math.Round(AvgWalkingTime(Category.C), 2)).ToString() +
                                                                                    "\r\n" + "Category D: " + (Math.Round(AvgWalkingTime(Category.D), 2)).ToString();

            string MaxNumberOfPatientePer24h = "\r\n" + "The maximum number of patients hospital can handle per category in 24h is: " + "\r\n" + "Category A: " + (Math.Round(MaxPatientsfor24h(Category.A), 2)).ToString()
                                                                                                                                       + "\r\n" + "Category B: " + (Math.Round(MaxPatientsfor24h(Category.B), 2)).ToString()
                                                                                                                                       + "\r\n" + "Category C: " + (Math.Round(MaxPatientsfor24h(Category.C), 2)).ToString()
                                                                                                                                   + "\r\n" + "Category D: " + (Math.Round(MaxPatientsfor24h(Category.D), 2)).ToString();

            fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(fs);
            try
            {
                sw.Write(SimulationInfo);
                sw.Write(NumberOfPatients);
                sw.Write(NumberOfRooms);
                sw.Write(NumberPerCategory);
                sw.Write(Waitingpatients);
                sw.Write(NumberOfDisPatPetCat);
                sw.Write(AvgTreatTimeinfo);
                sw.Write(AvgWalkingTimeInfo);
                sw.Write(MaxNumberOfPatientePer24h);
                sw.Write("\r\n" + "Simulation finsihed at: " + DateTime.Now);



                sw.Close();
            }

            catch (IOException)
            {
                MessageBox.Show("Problem while saving ");
            }
        }


        // save to pdf file report
        public void SaveToPDF()
        {

            SetDataForPpdFile();
            Document doc = new Document(PageSize.A4.Rotate());
            BaseFont Arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f_bold_15 = new iTextSharp.text.Font(Arial, 15, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_bold_12 = new iTextSharp.text.Font(Arial, 12, iTextSharp.text.Font.NORMAL);

            FileStream fs = new FileStream("Simulation Report.pdf", FileMode.Create);
            using (fs)
            {
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // information about hospital

                PdfPTable table1 = new PdfPTable(1);
                float[] width = new float[] { 40f, 60f };

                PdfPCell cell1 = new PdfPCell(new Phrase("\n\nHopsital Open Hospital", f_bold_15));
                PdfPCell cell2 = new PdfPCell(new Phrase("OpenStraat,5641JL", f_bold_12));
                PdfPCell cell3 = new PdfPCell(new Phrase("Eindhoven, The Netherlands", f_bold_12));

                cell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell3.Border = iTextSharp.text.Rectangle.NO_BORDER;

                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                cell3.HorizontalAlignment = Element.ALIGN_CENTER;

                table1.WidthPercentage = 40;
                table1.HorizontalAlignment = Element.ALIGN_LEFT;
                table1.AddCell(cell1);
                table1.AddCell(cell2);
                table1.AddCell(cell3);

                table1.SpacingAfter = 20;
                table1.SpacingBefore = 50;
                doc.Add(table1);

                //information about the simulation date
                TimeSpan date = DateTime.Now.Subtract(sim.StartTime);
                
                table1 = new PdfPTable(1);
                cell1 = new PdfPCell(new Phrase("Simulation Time: " + date.Hours + " H " + date.Minutes + " Min " + date.Seconds + " S ", f_bold_15));
                cell2 = new PdfPCell(new Phrase("Simulation Starts Date: " + sim.StartTime, f_bold_12));
                cell3 = new PdfPCell(new Phrase("Simulation Ends Date: " + DateTime.Now, f_bold_12));

                cell1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                cell2.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                cell3.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                cell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell3.Border = iTextSharp.text.Rectangle.NO_BORDER;

                table1.AddCell(cell1);
                table1.AddCell(cell2);
                table1.AddCell(cell3);

                table1.SpacingAfter = 20;
                table1.SpacingBefore = 50;
                PdfPTable table3 = new PdfPTable(1);
                table3.AddCell(table1);
                table3.HorizontalAlignment = Element.ALIGN_RIGHT;
                table3.WidthPercentage = 40;
                doc.Add(table3);



                // report category data 

                Paragraph paragraph = new Paragraph(new Phrase("Information per category ", f_bold_15));
                // paragraph.Add(new Phrase("XY", f_bold_12));
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(paragraph);


                PdfPTable table2 = new PdfPTable(8);
                table2.HorizontalAlignment = Element.ALIGN_RIGHT;
                table2.WidthPercentage = 40;

                string[] cellnames = new string[8];
                cellnames[0] = "Category";
                cellnames[1] = "Patients";
                cellnames[2] = "Rooms and beds";
                cellnames[3] = "Average waiting time";
                cellnames[4] = "Discharged patients";
                cellnames[5] = "Number of dead";
                cellnames[6] = "Average treated time";
                cellnames[7] = "Max patients /24h";




                for (int i = 0; i < 8; i++)
                {
                    PdfPCell cell5 = new PdfPCell(new Phrase(cellnames[i], f_bold_12));
                    cell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell5.FixedHeight = 20;
                    table2.AddCell(cell5);

                }


                foreach (var b in DataA)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (DataA[i] == null)
                        {
                            DataA[i] = 0;
                        }
                    }

                    PdfPCell cell5 = new PdfPCell(new Phrase(b.ToString(), f_bold_12));
                    cell5.FixedHeight = 20;
                    table2.AddCell(cell5);

                }


                foreach (var b in DataB)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (DataB[i] == null)
                        {
                            DataB[i] = 0;
                        }
                    }
                    PdfPCell cell6 = new PdfPCell(new Phrase(b.ToString(), f_bold_12));
                    cell6.FixedHeight = 20;
                    table2.AddCell(cell6);
                }


                foreach (var b in DataC)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (DataC[i] == null)
                        {
                            DataC[i] = 0;
                        }
                    }
                    PdfPCell cell6 = new PdfPCell(new Phrase(b.ToString(), f_bold_12));
                    cell6.FixedHeight = 20;
                    table2.AddCell(cell6);
                }

                foreach (var b in DataD)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (DataD[i] == null)
                        {
                            DataD[i] = 0;
                        }
                    }
                    PdfPCell cell6 = new PdfPCell(new Phrase(b.ToString(), f_bold_12));
                    cell6.FixedHeight = 20;
                    table2.AddCell(cell6);
                }

                table2.WidthPercentage = 100;
                width = new float[] { 70f, 70f, 120f, 130f, 150, 100, 100, 130 };
                table2.SetWidths(width);
                table2.SpacingBefore = 20;
                doc.Add(table2);

                Paragraph paragraph2 = new Paragraph(new Phrase("Recommandation :", f_bold_15));
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(paragraph2);



                Paragraph paragraph3A = new Paragraph(new Phrase(RecomandationsA[0].ToString(), f_bold_12));
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(paragraph3A);

                Paragraph paragraph3B = new Paragraph(new Phrase(RecomandationsB[0].ToString(), f_bold_12));
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(paragraph3B);

                Paragraph paragraph3C = new Paragraph(new Phrase(RecomandationsC[0].ToString(), f_bold_12));
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(paragraph3C);

                Paragraph paragraph3D = new Paragraph(new Phrase(RecomandationsD[0].ToString(), f_bold_12));
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(paragraph3D);

           
                doc.Close();
                System.Diagnostics.Process.Start(@"Simulation Report.pdf");
            }

        }



        public Room SelectedRoom()
        {
            foreach (Room r in sim.Rooms)
            {
                if (r.selected)
                    return r;
            }
            return null;
        }
        public string numberOfPatientsInRoom()
        {
            if(SelectedRoom() != null)
                return SelectedRoom().CurrentPatients.Count().ToString();
            return null;
        }

        public string allPatientsInRoom()
        {
            if (SelectedRoom() != null)
                return SelectedRoom().AllPatients.Count().ToString();
            return null;
        }

        public string numberOfBeds()
        {
            if (SelectedRoom() != null)
                return SelectedRoom().Beds.Count().ToString();
            return null;
        }

        public string occupiedNROfBeds()
        {
            int beds = 0;
            if(SelectedRoom() != null)
            {
                foreach (Bed b in SelectedRoom().Beds)
                {
                    if (b.Busy)
                        beds++;
                }
            }
            return beds.ToString();
        }
        public string availableNROfBeds()
        {
            int beds = 0;
            if (SelectedRoom() != null)
                beds = SelectedRoom().Beds.Count - Convert.ToInt32(occupiedNROfBeds());
            return beds.ToString();
        }


    }
}

