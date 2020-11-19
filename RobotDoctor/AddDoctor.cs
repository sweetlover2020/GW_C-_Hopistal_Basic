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
    public partial class AddDoctor : Form
    {
        public static Models.Doctor doctor = new Models.Doctor();
        public string action { get; set; }
        public AddDoctor(string action)
        {
            InitializeComponent();
            this.action = action;
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            if (this.action == "Add")
            {
                txtID.Text = Help.LastIdDoctor(Doctor.listDoctor);
                btn.Text = "add";
            }
            else if (this.action == "Update")
            {
                txtID.Text = doctor.ID.ToString();
                txtGender.Text = doctor.Gender.ToString();
                txtName.Text = AddDoctor.doctor.Name;
                txtAddress.Text = AddDoctor.doctor.Address;
                btn.Text = "update";
            }
            txtID.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isChecked = CheckAvailible();
          
            if (isChecked == true)
            {
               
                doctor.Name = txtName.Text.ToString();
                doctor.Address = txtAddress.Text.ToString();
                doctor.Gender = txtGender.Text.ToString();
               
                this.Close();
                doctor.ID = txtID.Text.ToString();
            }
        }
        public bool CheckAvailible()
        {
            string name = txtName.Text.ToString();
            string Address = txtAddress.Text.ToString();
            string Gender = txtGender.Text.ToString();

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

            return true;
        }


      
    }
    }
