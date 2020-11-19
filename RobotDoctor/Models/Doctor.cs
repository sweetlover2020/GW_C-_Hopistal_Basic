using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoctor.Models
{
   public class Doctor
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public List<Patient> listPatient { get; set; }


        public Doctor()
        {
            this.ID = "";
            this.Name = "";
            this.Address = "";
            this.Gender = "";
            this.listPatient = new List<Patient>();


        }
        public Doctor(string id, string name, string phone, string address)
        {
            this.ID = id;
            this.Name = name;
            this.Address = phone;
            this.Gender = address;
            this.listPatient = new List<Patient>();
        }

        public Doctor(Doctor d)
        {

            this.ID = d.ID;
            this.Name = d.Name;
            this.Address = d.Address;
            this.Gender = d.Gender;
            this.listPatient = d.listPatient.ToList<Patient>();
        }
    }
}
