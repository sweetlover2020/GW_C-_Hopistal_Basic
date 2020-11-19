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
    public partial class AddFood : Form
    {
        public static Food food = new Food();
        public string action3 { get; set; }
        public AddFood(string action3)
        {
            InitializeComponent();
            this.action3 = action3;
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            if (this.action3 == "Add")
            {
                txtID.Text = Help.LastIdFood(FFood1.listFood);
                btn3.Text = "add";
            }
            else if (this.action3 == "Update")
            {
              
                txtKind.Text = food.Kind.ToString();
                txtName.Text = food.Name.ToString();
                txtUnit.Text = food.Unit.ToString();
                txtDateOfManufacture.Text = food.DateOfManufacture.ToString();
                txtExpirationDate.Text = food.ExpirationDate.ToString();
                btn3.Text = "update";
            }
            txtID.Enabled = false;

        }
        public bool CheckAvailible3()
        {
            string Name = txtName.Text.ToString();
            string Unit = txtUnit.Text.ToString();
            string Kind = txtKind.Text.ToString();
            string DateOfManufacture = txtDateOfManufacture.Text.ToString();
            string ExpirationDate = txtExpirationDate.Text.ToString();


            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Unit))
            {
                MessageBox.Show("Address is empty");
                return false;
            }
            if (string.IsNullOrEmpty(Kind))
            {
                MessageBox.Show("Gender is empty");
                return false;
            }
            if (string.IsNullOrEmpty(DateOfManufacture))
            {
                MessageBox.Show("DateOfManufacture is empty");
                return false;
            }
            if (string.IsNullOrEmpty(ExpirationDate))
            {
                MessageBox.Show("ExpirationDate is empty");
                return false;
            }

            return true;
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            bool isChecked = CheckAvailible3();

            if (isChecked == true)
            {

                food.Name = txtName.Text.ToString();
                food.Unit = txtUnit.Text.ToString();
                food.Kind = txtKind.Text.ToString();
                food.DateOfManufacture = txtDateOfManufacture.Text.ToString();
                food.ExpirationDate = txtExpirationDate.Text.ToString();


                this.Close();
                food.ID = txtID.Text.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

