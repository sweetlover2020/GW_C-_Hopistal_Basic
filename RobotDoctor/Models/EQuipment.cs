using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoctor.Models
{
   public class EQuipment
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Kind { get; set; }
        public string DateOfManufacture { get; set; }
        

        public EQuipment()
        {
            this.ID = "";
            this.Name = "";
            this.Unit = "";
            this.Kind = "";
            this.DateOfManufacture = "";



        }
        public EQuipment(string ID, string Name, string Kind, string Unit, string DateOfManufacture)
        {
            this.ID = ID;
            this.Name = Name;
            this.Unit = Unit;
            this.Kind = Kind;
            this.DateOfManufacture = DateOfManufacture;
        }

        public EQuipment(EQuipment d)
        {

            this.ID = d.ID;
            this.Name = d.Name;
            this.Unit = d.Unit;
            this.Kind = d.Kind;
            this.DateOfManufacture = d.DateOfManufacture;

        }
    }
}



