using RobotDoctor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotDoctor
{
    public partial class Doctor : Form
    {
        public static List<Models.Doctor> listDoctor { get; set; }
        public static List<Models.Patient> listPatient { get; set; }
        public Patient patientSelected { get; set; }

        public Models.Doctor doctorSelected { get; set; }
        public Doctor()
        {
            InitializeComponent();
            Doctor.listDoctor = new List<Models.Doctor>(); 
            CreateDataDoctor();
            InitListView();
            LoadDoctor();
            
            Doctor.listPatient = new List<Models.Patient>();
            CreateDataPatient1();
            InitListView2();
            LoadPatient1();

        }
        public void InitListView()
        {
            lvDoctor.AutoArrange = true;
            lvDoctor.GridLines = true;
            lvDoctor.FullRowSelect = true;


            lvDoctor.View = View.Details;
        }
        public void InitListView2()
        {
            lvPatient.AutoArrange = true;
            lvPatient.GridLines = true;
            lvPatient.FullRowSelect = true;


            lvPatient.View = View.Details;
        }

        private void FBacsi_Load(object sender, EventArgs e)
        {

        }
        public void LoadDoctor()
        {
            lvDoctor.Items.Clear();

            Models.Doctor temp;
            for (int i = 0; i < Doctor.listDoctor.Count; i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (Models.Doctor)Doctor.listDoctor[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.ID.ToString());
                subItem.SubItems.Add(temp.Name.ToString());
                subItem.SubItems.Add(temp.Address.ToString());
                subItem.SubItems.Add(temp.Gender.ToString());


                lvDoctor.Items.Add(subItem);
            }


        }
        public void CreateDataPatient1()
        {
            

            Patient p5 = new Patient("0001", "Tom Hiddleston", "HCM City", "Male", "0988750238", "Tomlks@gmail.com", "Flu", "15/05/2020");
            Patient p6 = new Patient("0002", "Suzanna Smith", "HCM City", "Female", "0366210326", "Smith782@gmail.com", "Headache", "10/05/2020");
            Patient p7 = new Patient("0003", "Kim Hồng Hạnh", "HCM City", "Female", "0886740123", "Hanhkim29@gmail.com", "Headache", "15/05/2020");
            listPatient.Add(p5);
            listPatient.Add(p6);
            listPatient.Add(p7);
           
        }
        public void CreateDataDoctor()
        {
            // tạo ra các Doctor
            Models.Doctor d1 = new Models.Doctor("0001", "Võ Văn Tín", "HCM City", "Male");
            Models.Doctor d2 = new Models.Doctor("0002", "Trần Văn Học", "Đà Nẵng City", "Male");
            Models.Doctor d3 = new Models.Doctor("0003", "Kiều Hồng Oanh", "Hà Nội City", "Female");
            Models.Doctor d4 = new Models.Doctor("0004", "Jack C.Richards", "Sigapore", "Female");

            // add vào list 
            listDoctor.Add(d1);
            listDoctor.Add(d2);
            listDoctor.Add(d3);
            listDoctor.Add(d4);

        }








        private void button2_Click(object sender, EventArgs e)
        {
            AddDoctor formAddDoctor = new AddDoctor("Add");
            formAddDoctor.ShowDialog();
            if (AddDoctor.doctor != null)
            {
                Models.Doctor d = new Models.Doctor(AddDoctor.doctor);
            

                if (string.IsNullOrEmpty(d.ID.ToString()) || string.IsNullOrEmpty(d.Address.ToString()) || string.IsNullOrEmpty(d.Name.ToString()) || string.IsNullOrEmpty(d.Gender.ToString()))
                {
                    
                }
                else
                {
                    listDoctor.Add(d);
                    MessageBox.Show("Add successful");
                    LoadDoctor();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Doctor.listDoctor.Remove(this.doctorSelected);
            LoadDoctor();
            MessageBox.Show("Delete successful");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDoctor formUpdate = new AddDoctor("Update");
            int index = Doctor.listDoctor.IndexOf(this.doctorSelected);
            AddDoctor.doctor.ID = doctorSelected.ID;
            AddDoctor.doctor.Name = doctorSelected.Name;
            AddDoctor.doctor.Address = doctorSelected.Address;
            AddDoctor.doctor.Gender = doctorSelected.Gender;
            formUpdate.ShowDialog();

            Models.Doctor d = (Models.Doctor)listDoctor[index];
            d.ID = AddDoctor.doctor.ID;
            d.Name = AddDoctor.doctor.Name;
            d.Address = AddDoctor.doctor.Address;
            d.Gender = AddDoctor.doctor.Gender;
            AddDoctor.doctor = null;
            LoadDoctor();
            MessageBox.Show("Update successful");
        }
        private void lvDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                doctorSelected = (Models.Doctor)Doctor.listDoctor[index];
            }
        }

        public void LoadPatient1()
        {
            lvPatient.Items.Clear();
           
            Patient temp1;
            for (int i = 0; i < Doctor.listPatient.Count; i++)
            {
                ListViewItem subItem1 = new ListViewItem();
                temp1 = (Patient)Doctor.listPatient[i];
                subItem1.Text = i.ToString();
                subItem1.SubItems.Add(temp1.ID.ToString());
                subItem1.SubItems.Add(temp1.Name.ToString());
                subItem1.SubItems.Add(temp1.Address.ToString());
                subItem1.SubItems.Add(temp1.Gender.ToString());
                subItem1.SubItems.Add(temp1.Email.ToString());
                subItem1.SubItems.Add(temp1.Phone.ToString());
                subItem1.SubItems.Add(temp1.Status.ToString());
                subItem1.SubItems.Add(temp1.Datecheck.ToString());




                lvPatient.Items.Add(subItem1);
            }
        }
       

      

        
        private void button4_Click(object sender, EventArgs e)
        {
            AddPatient1 formPatient1 = new AddPatient1("Add");
            formPatient1.ShowDialog();
            if (AddPatient1.patient != null)
            {
                Patient d1 = new Patient(AddPatient1.patient);

                if (string.IsNullOrEmpty(d1.ID.ToString()) || string.IsNullOrEmpty(d1.Address.ToString()) || string.IsNullOrEmpty(d1.Name.ToString()) || string.IsNullOrEmpty(d1.Gender.ToString()) || string.IsNullOrEmpty(d1.Email.ToString()) || string.IsNullOrEmpty(d1.Phone.ToString()) || string.IsNullOrEmpty(d1.Status.ToString()) || string.IsNullOrEmpty(d1.Datecheck.ToString()))
                {

                }
                else
                {
                    listPatient.Add(d1);
                    MessageBox.Show("Add successful");
                    LoadPatient1();
                }
            }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPatient1 formUpdate1 = new AddPatient1("Update");
            int index1 = Doctor.listPatient.IndexOf(this.patientSelected);
            AddPatient1.patient.ID = patientSelected.ID;
            AddPatient1.patient.Name = patientSelected.Name;
            AddPatient1.patient.Address = patientSelected.Address;
            AddPatient1.patient.Gender = patientSelected.Gender;
            AddPatient1.patient.Email = patientSelected.Email;
            AddPatient1.patient.Phone = patientSelected.Phone;
            AddPatient1.patient.Status = patientSelected.Status;
            AddPatient1.patient.Datecheck = patientSelected.Datecheck;
            formUpdate1.ShowDialog();

            Patient d1 = (Patient)listPatient[index1];
            d1.ID = AddPatient1.patient.ID;
            d1.Name = AddPatient1.patient.Name;
            d1.Address = AddPatient1.patient.Address;
            d1.Gender = AddPatient1.patient.Gender;
            d1.Email = AddPatient1.patient.Email;
            d1.Phone = AddPatient1.patient.Phone;
            d1.Status = AddPatient1.patient.Status;
            d1.Datecheck = AddPatient1.patient.Datecheck;
            AddPatient1.patient = null;
            LoadPatient1();
            MessageBox.Show("Update successful");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lvPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateDataPatient1();
            ListView lsv1 = sender as ListView;
            if (lsv1.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv1.SelectedItems[0];
                int index1 = Convert.ToInt32(item.Text);
                patientSelected = (Patient)Doctor.listPatient[index1];
            }

        }

        private void btnRemove_click(object sender, EventArgs e)
        {
            Doctor.listPatient.Remove(this.patientSelected);
            LoadPatient1();
            MessageBox.Show("Delete successful");
        }
    }
}
