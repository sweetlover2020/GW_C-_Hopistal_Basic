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
    public partial class AddEQuipment : Form
    {

        public static EQuipment eQuipment = new EQuipment();
        public string action5 { get; set; }
        public AddEQuipment(string action5)
        {
            InitializeComponent();
            this.action5 = action5;
        }

        private void AddEQuipMent_Load(object sender, EventArgs e)
        {
            if (this.action5 == "Add")
            {
                txtID.Text = Help.LastIdEQuipment(FFood1.ListeQuipment);
                btn5.Text = "add";
            }
            else if (this.action5 == "Update")
            {
                txtID.Text = eQuipment.ID.ToString();
                txtName.Text = eQuipment.Name.ToString();
                txtUnit.Text = eQuipment.Unit.ToString();
                txtKind.Text = eQuipment.Kind.ToString();
                txtDateOfManufacture.Text =eQuipment.DateOfManufacture.ToString();
                btn5.Text = "update";
            }
            txtID.Enabled = false;
        }
        public bool CheckAvailible5()
        {
            string ID = txtID.Text.ToString();
            string name = txtName.Text.ToString();
            string Unit = txtUnit.ToString();
            string Kind = txtKind.ToString();
            string DateOfManufacture = txtDateOfManufacture.ToString();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Address is empty");
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

       

        private void btn5_Click(object sender, EventArgs e)
        {
            bool isChecked = CheckAvailible5();
           
            if (isChecked == true)
            {

                //CreateDoctor();
                eQuipment.Name = txtName.Text.ToString();
                eQuipment.Unit = txtUnit.Text.ToString();
                eQuipment.Kind = txtKind.Text.ToString();
                eQuipment.DateOfManufacture = txtDateOfManufacture.Text.ToString();


                this.Close();
                eQuipment.ID = txtID.Text.ToString();
            }
    }
    }
}
