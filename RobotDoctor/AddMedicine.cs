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
    public partial class AddMedicine : Form
    {
        public static Medicine Medicine = new Medicine();
        public string action2 { get; set; }

    
        public AddMedicine(string action)
        {
            InitializeComponent();
            this.action2 = action;
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            if (this.action2 == "Add")
            {
                txtID.Text = Help.LastIdMedicine(FFood1.listMedicine);
                btn.Text = "add";
            }
            else if (this.action2 == "Update")
                txtID.Text = Medicine.ID.ToString();
                txtName.Text = Medicine.Name.ToString();
            {
                txtUnit.Text = AddMedicine.Medicine.Unit;
                txtKind.Text = AddMedicine.Medicine.Kind;
                txtDateOfManufacture.Text = AddMedicine.Medicine.DateOfManufacture;
                btn.Text = "update";
            }
            txtID.Enabled = false;
        }
        public bool CheckAvailible2()
        {
            string ID = txtID.Text.ToString();
            string name = txtName.Text.ToString();
            string Unit= txtUnit.ToString();
            string Kind  = txtKind.ToString();
            string DateOfManufacture = txtDateOfManufacture.ToString();

            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Address is empty");
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Unit))
            {
                MessageBox.Show("Gender is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Kind))
            {
                MessageBox.Show("Gender is empty");
                return false;
            }
            if (string.IsNullOrEmpty(DateOfManufacture))
            {
                MessageBox.Show("Gender is empty");
                return false;
            }

            return true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            bool isChecked = CheckAvailible2();
            
            if (isChecked == true)
            {
                //CreateDoctor();
                Medicine.Name = txtName.Text.ToString();
                Medicine.Unit = txtUnit.Text.ToString();
                Medicine.Kind = txtKind.Text.ToString();
                Medicine.DateOfManufacture = txtDateOfManufacture.Text.ToString();
              

                this.Close();
                Medicine.ID = txtID.Text.ToString();
            }
        }
    }
}
