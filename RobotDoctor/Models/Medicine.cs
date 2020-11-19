using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoctor.Models
{
   public class Medicine
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Kind { get; set; }
        public string DateOfManufacture { get; set; }
        


        public Medicine()
        {
            this.ID = "";
            this.Name = "";
            this.Unit = "";
            this.Kind = "";
            this.DateOfManufacture = "";
         


        }
        public Medicine(string id, string name, string Kind, string Unit,string DateOfManufacture)
        {
            this.ID = id;
            this.Name = name;
            this.Unit = Unit;
            this.Kind = Kind;
            this.DateOfManufacture = DateOfManufacture;
        }

        public Medicine(Medicine d)
        {

            this.ID = d.ID;
            this.Name = d.Name;
            this.Unit = d.Unit;
            this.Kind = d.Kind;
            this.DateOfManufacture = d.DateOfManufacture;
          
        }
    }
}

