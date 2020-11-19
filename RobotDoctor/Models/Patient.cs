using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoctor.Models
{
    public class Patient
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string Datecheck { get; set; }
        public Patient()
        {
            this.ID = "";
            this.Name = "";
            this.Address = "";
            this.Gender = "";
            this.Email = "";
            this.Phone = "";
            this.Status = "";
            this.Datecheck = "";
        }
        public Patient(string ID, string Name, string Address, string Gender, string Phone, string Email, string Status, string Datecheck)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            this.Status = Status;
            this.Datecheck = Datecheck;
        }

        public Patient(Patient d)
        {
            this.ID = d.ID;
            this.Name = d.Name;
            this.Address = d.Address;
            this.Gender = d.Gender;
            this.Email = d.Email;
            this.Phone = d.Phone;
            this.Status = d.Status;
            this.Datecheck = d.Datecheck;
        }

    }
    }
    

