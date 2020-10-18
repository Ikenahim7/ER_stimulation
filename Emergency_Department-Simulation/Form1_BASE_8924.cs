using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Emergency_Department_Simulation
{
    public partial class Form1 : Form
    {
        public Simulation sim { get; private set; }
        public static Size size;
        private DataFileHelper Data;
        private Timer time = new Timer();

        public Form1()
        {
            InitializeComponent();
            size = pbSimulation.Size;
            sim = new Simulation();
            Data = new DataFileHelper("Simulation report.txt",sim);

            categoryComboBox.Items.Add("Random");
            categoryComboBox.Items.Add(Category.A);
            categoryComboBox.Items.Add(Category.B);
            categoryComboBox.Items.Add(Category.C);
            categoryComboBox.Items.Add(Category.D);
            categoryComboBox.SelectedIndex = 0;

            tbRoomA.Text = "4";
            tbRoomB.Text = "4";
            tbRoomC.Text = "5";
            tbRoomD.Text = "11";
            tbBedA.Text = "2";
            tbBedB.Text = "3";
            tbBedC.Text = "1";
            tbBedD.Text = "1";
        }
        private void pbSimulation_Paint(object sender, PaintEventArgs e)
        {
            sim.NavigatePatients();
            sim.Draw(e.Graphics);
        }
        private void addPatientsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int nr = Convert.ToInt32(nrOfPatientsTextBox.Text);
                Category category;

                if(categoryComboBox.SelectedIndex > 0)
                {
                    category = (Category)categoryComboBox.SelectedItem;
                    sim.AddPatients(nr, category);
                }
                else
                {
                    sim.AddPatients(nr);
                }

                pbSimulation.Invalidate();
                nrOfPatientsTextBox.Text = "";
                categoryComboBox.SelectedIndex = 0;
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong format!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sim.Stop();
        }

        private void ShowInfo()
        {
            patientsTotalNRLabel.Text = Data.GetNrOfAllPatients().ToString();
            patientsCurrentNRLabel.Text = Data.GetNrOfCurentPatients().ToString();
            patientsAvgWaitingLabel.Text = Data.GetAverageWaitingTime().ToString("0.##");
            patientsAvgTreatLabel.Text = Data.GetAverageTreatTime().ToString("0.##");
            patientsLeftLabel.Text = Data.GetNrOfLeftPatients().ToString();
            patientsWaitingLabel.Text = Data.GerNrOfWaitingPatients().ToString();
            patientsInRoomLabel.Text = Data.GetNrOfPatientsInRoom().ToString();
            DeadTotalPatientsLabel.Text = Data.TotalNumberOfDeathPatients().ToString();

            patientsATotalLabel.Text = Data.GetNrOfAllPatients(Category.A).ToString();
            patientsACurrentLabel.Text = Data.GetNrOfCurentPatients(Category.A).ToString();
            patientsAAvgWaitingLabel.Text = Data.GetAverageWaitingTime(Category.A).ToString("0.##");
            patientsAAvgTreatLabel.Text = Data.GetAverageTreatTime(Category.A).ToString("0.##");
            patientsALeftLabel.Text = Data.GetNrOfLeftPatients(Category.A).ToString();
            patientsAWaitingLabel.Text = Data.GerNrOfWaitingPatients(Category.A).ToString();
            patientsAInRoomLabel.Text = Data.GetNrOfPatientsInRoom(Category.A).ToString();
            DeadPatientsALabel.Text = Data.NumberOfDeathPatientPerCat(Category.A).ToString();

            patientsBTotalLabel.Text = Data.GetNrOfAllPatients(Category.B).ToString();
            patientsBCurrentLabel.Text = Data.GetNrOfCurentPatients(Category.B).ToString();
            patientsBAvgWaitingLabel.Text = Data.GetAverageWaitingTime(Category.B).ToString("0.##");
            patientsBAvgTreatLabel.Text = Data.GetAverageTreatTime(Category.B).ToString("0.##");
            patientsBLeftLabel.Text = Data.GetNrOfLeftPatients(Category.B).ToString();
            patientsBWaitingLabel.Text = Data.GerNrOfWaitingPatients(Category.B).ToString();
            patientsBInRoomLabel.Text = Data.GetNrOfPatientsInRoom(Category.B).ToString();
            DeadPatientsBLabel.Text = Data.NumberOfDeathPatientPerCat(Category.B).ToString();

            patientsCTotalLabel.Text = Data.GetNrOfAllPatients(Category.C).ToString();
            patientsCCurrentLabel.Text = Data.GetNrOfCurentPatients(Category.C).ToString();
            patientsCAvgWaitingLabel.Text = Data.GetAverageWaitingTime(Category.C).ToString("0.##");
            patientsCAvgTreatLabel.Text = Data.GetAverageTreatTime(Category.C).ToString("0.##");
            patientsCLeftLabel.Text = Data.GetNrOfLeftPatients(Category.C).ToString();
            patientsCWaitingLabel.Text = Data.GerNrOfWaitingPatients(Category.C).ToString();
            patientsCInRoomLabel.Text = Data.GetNrOfPatientsInRoom(Category.C).ToString();
            DeadPatientsCLabel.Text = Data.NumberOfDeathPatientPerCat(Category.C).ToString();

            patientsDTotalNrLabel.Text = Data.GetNrOfAllPatients(Category.C).ToString();
            patientsDCurrentLabel.Text = Data.GetNrOfCurentPatients(Category.D).ToString();
            patientsDAvgWaitingLabel.Text = Data.GetAverageWaitingTime(Category.D).ToString("0.##");
            patientsDAvgTreatLabel.Text = Data.GetAverageTreatTime(Category.D).ToString("0.##");
            patientsDLeftLabel.Text = Data.GetNrOfLeftPatients(Category.D).ToString();
            patientsDWaitingLabel.Text = Data.GerNrOfWaitingPatients(Category.D).ToString();
            patientsDInRoomLabel.Text = Data.GetNrOfPatientsInRoom(Category.D).ToString();
            DeadPatientsDLabel.Text = Data.NumberOfDeathPatientPerCat(Category.D).ToString();
        }

        int counter = 0;
        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (cbContinuousPatients.Checked && counter % Convert.ToInt32(tbSecondsPerPatient.Text) == 0)
                sim.AddPatients(1);
            pbSimulation.Invalidate();
            ShowInfo();
        }

        public void GeneratePlan(int[] a, int[] b, int[] c, int[] d)
        {
            sim.AddRoomsAndBeds(a, b, c, d);
            pbSimulation.Invalidate();
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if(sim.Running)
            {
                sim.Stop();
                simulationTimer.Stop();
                warningTimer.Stop();
                startStopButton.Text = "Start";
                startStopButton.BackColor = Color.Green;
            }
            else
            {
                sim.Start();
                simulationTimer.Start();
                warningTimer.Start();
                startStopButton.Text = "Stop";
                startStopButton.BackColor = Color.Red;
            }

            bt_save_report.Enabled = true;
        }

        private void room_Click(object sender, MouseEventArgs e)
        {
            foreach (Room r in sim.Rooms)
            {
                if (e.X > r.Location.X && e.Y > r.Location.Y && e.X < r.Location.X + 50 && e.Y < r.Location.Y + 50)
                {
                    r.selected = true;
                    // lbRoomInformation.Text = r.Location.X.ToString() + " " + r.Location.Y.ToString() + " " + r.Category.ToString();
                }
                else
                    r.selected = false;
            }
        }

        private void bt_save_report_Click(object sender, EventArgs e)
        {
            Data.SaveToFile();
            Data.SaveToPDF();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int[] a = new int[] { Convert.ToInt32(tbRoomA.Text), Convert.ToInt32(tbBedA.Text) };
                int[] b = new int[] { Convert.ToInt32(tbRoomB.Text), Convert.ToInt32(tbBedB.Text) };
                int[] c = new int[] { Convert.ToInt32(tbRoomC.Text), Convert.ToInt32(tbBedC.Text) };
                int[] d = new int[] { Convert.ToInt32(tbRoomD.Text), Convert.ToInt32(tbBedD.Text) };

                GeneratePlan(a, b, c, d);
            }
            catch (FormatException)
            {
                //do nothing
            }
        }

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            int nr = sim.GetCritical();

            if(nr != 0)
            {
                warningLabel.Text = nr + " patients are in critical state!";
            }
            else
            {
                warningLabel.Text = "";
            }
        }
    }
}
