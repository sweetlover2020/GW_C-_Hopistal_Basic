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
    public partial class AddPatient1 : Form
    {
        public static Patient patient = new Patient();
        public string action { get; set; }
        public AddPatient1(string Action)
        {
            InitializeComponent();
            this.action = Action;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        private void btn1_Click_1(object sender, EventArgs e)
        {
            bool isChecked = CheckAvailible1();

            if (isChecked == true)
            {
                patient.Name = txtName.Text.ToString();
                patient.Address = txtAddress.Text.ToString();
                patient.Gender = txtGender.Text.ToString();
                patient.Email = txtEmail.Text.ToString();
                patient.Phone = txtPhone.Text.ToString();
                patient.Status = txtStatus.Text.ToString();
                patient.Datecheck = txtDatecheck.Text.ToString();
                this.Close();
                patient.ID = txtID.Text.ToString();
            }
        }
        public bool CheckAvailible1()
        {
            string name = txtName.Text.ToString();
            string Address = txtAddress.Text.ToString();
            string Gender = txtGender.Text.ToString();
            string Email = txtEmail.Text.ToString();
            string Phone = txtPhone.Text.ToString();
            string Status = txtStatus.Text.ToString();
            string Datecheck = txtDatecheck.Text.ToString();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Address))
            {
                MessageBox.Show("Address is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Gender))
            {
                MessageBox.Show("Gender is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Email is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Phone is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Status))
            {
                MessageBox.Show("Status is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Datecheck))
            {
                MessageBox.Show("Datecheck is empty");
                return false;
            }
            return true;
        }

        
    }
    }

