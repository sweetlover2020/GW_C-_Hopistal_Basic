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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFoodWater_Click(object sender, EventArgs e)
        {
            FFood1 food = new FFood1();
            food.Show();
            this.Show();

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Infor infor = new Infor();
            infor.Show();
            this.Show();
        }
    }
}
