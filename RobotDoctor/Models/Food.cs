using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoctor.Models
{
    public class Food
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Kind { get; set; }
        public string DateOfManufacture { get; set; }
        public string ExpirationDate { get; set; }
        public Food()
        {
            this.ID = "";
            this.Name = "";
            this.Unit = "";
            this.Kind = "";
            this.DateOfManufacture = "";
            this.ExpirationDate = "";



        }
        public Food(string ID, string Name, string Kind, string Unit, string DateOfManufacture,string ExpirationDate)
        {
            this.ID = ID;
            this.Name = Name;
            this.Unit = Unit;
            this.Kind = Kind;
            this.DateOfManufacture = DateOfManufacture;
            this.ExpirationDate = ExpirationDate;
        }

        public Food(Food d)
        {

            this.ID = d.ID;
            this.Name = d.Name;
            this.Unit = d.Unit;
            this.Kind = d.Kind;
            this.DateOfManufacture = d.DateOfManufacture;
            this.ExpirationDate = d.ExpirationDate;

        }
    }
}


