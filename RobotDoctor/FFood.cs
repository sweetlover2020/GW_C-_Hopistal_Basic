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
    public partial class FFood1 : Form
    {
        public static List<Medicine> listMedicine { get; set; }
        public Medicine medicineSelected { get; set; }
        public static List<Food> listFood { get; set; }
        public Food foodSelected { get; set; }
        public static List<EQuipment> ListeQuipment { get; set; }
        public EQuipment eQuipmentSelected { get; set; }
        public FFood1()
        {
            InitializeComponent();
            FFood1.listMedicine = new List<Medicine>();
            CreateDataMedicine();
            InitListView();
            LoadMedicine();

            FFood1.listFood = new List<Food>();
            
            CreateDataFood();
            InitListView1();
            LoadFood();

            FFood1.ListeQuipment = new List<EQuipment>();
            CreateDataEQuipment();
            InitListView3();
            LoadEQuipment1();


        }

        public void InitListView()
        {
            lvMedicine.AutoArrange = true;
            lvMedicine.GridLines = true;
            lvMedicine.FullRowSelect = true;


            lvMedicine.View = View.Details;
        }
        public void InitListView1()
        {
            lvFood.AutoArrange = true;
            lvFood.GridLines = true;
            lvFood.FullRowSelect = true;


            lvFood.View = View.Details;
        }
        public void InitListView3()
        {
            lvEQuipment2.AutoArrange = true;
            lvEQuipment2.GridLines = true;
            lvEQuipment2.FullRowSelect = true;


            lvEQuipment2.View = View.Details;
        }


            private void btn_Click(object sender, EventArgs e)
        {
            AddMedicine formAddMedicine = new AddMedicine("Add");
            formAddMedicine.ShowDialog();
            if (AddMedicine.Medicine != null)
            {
                Medicine d2 = new Medicine(AddMedicine.Medicine);


                if (string.IsNullOrEmpty(d2.ID.ToString()) || string.IsNullOrEmpty(d2.Name.ToString()) || string.IsNullOrEmpty(d2.Unit.ToString()) || string.IsNullOrEmpty(d2.Kind.ToString()) || string.IsNullOrEmpty(d2.DateOfManufacture.ToString()))
                {

                }
                else
                {
                    listMedicine.Add(d2);
                    MessageBox.Show("Add successful");
                    LoadMedicine();
                }
            }
        }
        public void LoadMedicine()
        {
            lvMedicine.Items.Clear();

            Medicine temp2;
            for (int i = 0; i < FFood1.listMedicine.Count; i++)
            {
                ListViewItem subItem2 = new ListViewItem();
                temp2 = (Medicine)FFood1.listMedicine[i];
                subItem2.Text = i.ToString();
                subItem2.SubItems.Add(temp2.ID.ToString());
                subItem2.SubItems.Add(temp2.Name.ToString());
                subItem2.SubItems.Add(temp2.Unit.ToString());
                subItem2.SubItems.Add(temp2.Kind.ToString());
                subItem2.SubItems.Add(temp2.DateOfManufacture.ToString());

                lvMedicine.Items.Add(subItem2);
            }
        }
        public void LoadFood()
        {
            lvFood.Items.Clear();

            Food temp3;
            for (int i = 0; i < FFood1.listFood.Count; i++)
            {
                ListViewItem subItem3 = new ListViewItem();
                temp3 = (Food)FFood1.listFood[i];
                subItem3.Text = i.ToString();
                subItem3.SubItems.Add(temp3.ID.ToString());
                subItem3.SubItems.Add(temp3.Name.ToString());
                subItem3.SubItems.Add(temp3.Unit.ToString());
                subItem3.SubItems.Add(temp3.Kind.ToString());
                subItem3.SubItems.Add(temp3.DateOfManufacture.ToString());
                subItem3.SubItems.Add(temp3.ExpirationDate.ToString());

                lvFood.Items.Add(subItem3);
            }
        }
        public void LoadEQuipment1()
        {
            lvEQuipment2.Items.Clear();

            EQuipment temp5;
            for (int i = 0; i < FFood1.ListeQuipment.Count; i++)
            {
                ListViewItem subItem5 = new ListViewItem();
                temp5 = (EQuipment)FFood1.ListeQuipment[i];
                subItem5.Text = i.ToString();
                subItem5.SubItems.Add(temp5.ID.ToString());
                subItem5.SubItems.Add(temp5.Name.ToString());
                subItem5.SubItems.Add(temp5.Unit.ToString());
                subItem5.SubItems.Add(temp5.Kind.ToString());
                subItem5.SubItems.Add(temp5.DateOfManufacture.ToString());

                lvEQuipment2.Items.Add(subItem5);
            }
        }
            public void CreateDataMedicine()
        {

            Medicine m1 = new Medicine("0001", "Panadol", "190 box", "Solid", "15/05/2020");
            Medicine m2 = new Medicine("0002", "Flexneri", "250 vials", "Liquid", "15/05/2020");
            Medicine m3 = new Medicine("0003", "Piaorhaw", "250 box", "Liquid", "10/05/2020");
            Medicine m4 = new Medicine("0004", "Opawhad", "250 vials", "Liquid", "08/05/2020");
            listMedicine.Add(m1);
            listMedicine.Add(m2);
            listMedicine.Add(m3);
            listMedicine.Add(m4);
        }
        public void CreateDataFood()
        {

            Food fo1 = new Food("0001", "Tendon", "Meat", "100 box", "15/05/2020", "17/05/2020");
            Food fo2 = new Food("0002", "Burnt rice", "Fastfood", "100 vials", "10/05/2020", "17/10/2020");
            Food fo3 = new Food("0003", "Banh Mi", "Fastfood", "100 ", "10/05/2020", "18/10/2020");
            Food fo4 = new Food("0004", "Pizza", "Fastfood", "100 ", "10/05/2020", "18/10/2020");
            listFood.Add(fo1);
            listFood.Add(fo2);
            listFood.Add(fo3);
            listFood.Add(fo4);
        }
        public void CreateDataEQuipment()
        {

            EQuipment eq1 = new EQuipment("0001", "Drag", "2500", "Cut", "15/3/2020");
            EQuipment eq2 = new EQuipment("0002", "Hammer", "110", "Medical", "18/12/2019");
            EQuipment eq3 = new EQuipment("0003", "Pliers", "287", "Tools", "30/02/2020");
            EQuipment eq4 = new EQuipment("0004", "Knife", "342", "Tools", "12/01/2020");
            EQuipment eq5 = new EQuipment("0005", "Syringe", "1135", "Medical", "16/05/2020");     
            ListeQuipment.Add(eq1);
            ListeQuipment.Add(eq2);
            ListeQuipment.Add(eq3);
            ListeQuipment.Add(eq4);
            ListeQuipment.Add(eq5);
           
        }

        private void FFood_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMedicine formUpdate2 = new AddMedicine("Update");
            int index2 = FFood1.listMedicine.IndexOf(this.medicineSelected);
            AddMedicine.Medicine.ID = medicineSelected.ID;
            AddMedicine.Medicine.Name = medicineSelected.Name;
            AddMedicine.Medicine.Unit = medicineSelected.Unit;
            AddMedicine.Medicine.Kind = medicineSelected.Kind;
            formUpdate2.ShowDialog();

            Medicine d = (Medicine)listMedicine[index2];
            d.ID = AddMedicine.Medicine.ID;
            d.Name = AddMedicine.Medicine.Name;
            d.Unit = AddMedicine.Medicine.Unit;
            d.Kind = AddMedicine.Medicine.Kind;
            d.DateOfManufacture = AddMedicine.Medicine.DateOfManufacture;
            AddMedicine.Medicine = null;
            LoadMedicine();
            MessageBox.Show("Update successful");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FFood1.listMedicine.Remove(this.medicineSelected);
            LoadMedicine();
            MessageBox.Show("Delete successful");
        }

        private void lvMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsvm = sender as ListView;
            if (lsvm.SelectedItems.Count == 1)
            {
                ListViewItem item = lsvm.SelectedItems[0];
                int index2 = Convert.ToInt32(item.Text);
                medicineSelected = (Medicine)FFood1.listMedicine[index2];
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddFood formAddFood = new AddFood("Add");
            formAddFood.ShowDialog();
            if (AddFood.food != null)
            {
                Food d3 = new Food(AddFood.food);


                if (string.IsNullOrEmpty(d3.ID.ToString()) || string.IsNullOrEmpty(d3.Name.ToString()) || string.IsNullOrEmpty(d3.Unit.ToString()) || string.IsNullOrEmpty(d3.Kind.ToString()) || string.IsNullOrEmpty(d3.DateOfManufacture.ToString()) || string.IsNullOrEmpty(d3.ExpirationDate.ToString())) 
                {

                }
                else
                {
                    listFood.Add(d3);
                    MessageBox.Show("Add successful");
                    LoadFood();
                }
            }
        }

        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsvf = sender as ListView;
            if (lsvf.SelectedItems.Count == 1)
            {
                ListViewItem item = lsvf.SelectedItems[0];
                int index3 = Convert.ToInt32(item.Text);
                foodSelected = (Food)FFood1.listFood[index3];
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            AddFood formUpdate3 = new AddFood("Update");
            int index3 = FFood1.listFood.IndexOf(this.foodSelected);
            AddFood.food.ID = foodSelected.ID;
            AddFood.food.Name = foodSelected.Name;
            AddFood.food.Unit = foodSelected.Unit;
            AddFood.food.Kind = foodSelected.Kind;
            AddFood.food.DateOfManufacture = foodSelected.DateOfManufacture;
            AddFood.food.ExpirationDate = foodSelected.ExpirationDate;
            formUpdate3.ShowDialog();

            Food d = (Food)listFood[index3];
            d.ID = AddFood.food.ID;
            d.Name = AddFood.food.Name;
            d.Unit = AddFood.food.Unit;
            d.Kind = AddFood.food.Kind;
            d.DateOfManufacture = AddFood.food.DateOfManufacture; ;
            d.ExpirationDate = AddFood.food.ExpirationDate;
            AddFood.food = null;
            LoadFood();
            MessageBox.Show("Update successful");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FFood1.listFood.Remove(this.foodSelected);
            LoadFood();
            MessageBox.Show("Delete successful");
        }

      

       

        private void lvEQuipment2_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView lsveq = sender as ListView;
            if (lsveq.SelectedItems.Count == 1)
            {
                ListViewItem item = lsveq.SelectedItems[0];
                int index5 = Convert.ToInt32(item.Text);
                eQuipmentSelected = (EQuipment)FFood1.ListeQuipment[index5];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddEQuipment formAddEquipment = new AddEQuipment("Add");
            formAddEquipment.ShowDialog();
            if (AddEQuipment.eQuipment != null)
            {
                EQuipment d5 = new EQuipment(AddEQuipment.eQuipment);


                if (string.IsNullOrEmpty(d5.ID.ToString()) || string.IsNullOrEmpty(d5.Name.ToString()) || string.IsNullOrEmpty(d5.Unit.ToString()) || string.IsNullOrEmpty(d5.Kind.ToString()) || string.IsNullOrEmpty(d5.DateOfManufacture.ToString()))
                {

                }
                else
                {
                    ListeQuipment.Add(d5);
                    MessageBox.Show("Add successful");
                    LoadEQuipment1();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddEQuipment formUpdate5 = new AddEQuipment("Update");
            int index5 = FFood1.ListeQuipment.IndexOf(this.eQuipmentSelected);
            AddEQuipment.eQuipment.ID = eQuipmentSelected.ID;
            AddEQuipment.eQuipment.Name = eQuipmentSelected.Name;
            AddEQuipment.eQuipment.Unit = eQuipmentSelected.Unit;
            AddEQuipment.eQuipment.Kind = eQuipmentSelected.Kind;
            AddEQuipment.eQuipment.DateOfManufacture = eQuipmentSelected.DateOfManufacture;
          
            formUpdate5.ShowDialog();

            EQuipment d = (EQuipment)ListeQuipment[index5];
            d.ID = AddEQuipment.eQuipment.ID;
            d.Name = AddEQuipment.eQuipment.Name;
            d.Unit = AddEQuipment.eQuipment.Unit;
            d.Kind = AddEQuipment.eQuipment.Kind;
            d.DateOfManufacture = AddEQuipment.eQuipment.DateOfManufacture; ;

            AddEQuipment.eQuipment = null;
            LoadEQuipment1();
            MessageBox.Show("Update successful");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FFood1.ListeQuipment.Remove(this.eQuipmentSelected);
            LoadEQuipment1();
            MessageBox.Show("Delete successful");
        }
    }
    }
