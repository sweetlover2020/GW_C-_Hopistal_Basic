using RobotDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDoctor
{
    class Help
    {
        public static bool IsNumeric(object Expression)
        {
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static string LastIdDoctor(List<Models.Doctor> list)
        {
            string id = "";
            // 3 doctor thì last index 0, 1, 2 => Length - 1 = 3 - 1 = 2
            Models.Doctor temp = (Models.Doctor)list[list.Count() - 1];
            // lấy id cuối cùng trong bảng Doctor
            int lastId = Convert.ToInt32(temp.ID);
            // id = 10
            // => 0010 thêm 2 số 0
            // 4 - id.ToString().Length 5=> 1 ; 14 => 2; 154 => 3  
            for (int i = 0; i < 4 - lastId.ToString().Length; i++)
            {
                id += "0";
            }
            return id + (lastId + 1).ToString();
        }
        public static string LastIdPatient(List<Patient> list)
        {
            string id = "";
            
            Patient temp1 = (Patient)list[list.Count() - 1];
            
            int lastId = Convert.ToInt32(temp1.ID);
          
            for (int i = 0; i < 4 - lastId.ToString().Length; i++)
            {
                id += "0";
            }
            return id + (lastId + 1).ToString();
        }
        public static string LastIdMedicine(List<Medicine> list)
        {
            string id = "";
            
            Medicine temp2 = (Medicine)list[list.Count() - 1];
            
            int lastId = Convert.ToInt32(temp2.ID);
            
            for (int i = 0; i < 4 - lastId.ToString().Length; i++)
            {
                id += "0";
            }
            return id + (lastId + 1).ToString();
        }
        public static string LastIdFood(List<Food> list)
        {
            string id = "";

            Food temp3 = (Food)list[list.Count() - 1];

            int lastId = Convert.ToInt32(temp3.ID);

            for (int i = 0; i < 4 - lastId.ToString().Length; i++)
            {
                id += "0";
            }
            return id + (lastId + 1).ToString();
        }
        public static string LastIdEQuipment(List<EQuipment> list)
        {
            string id = "";

            EQuipment temp4 = (EQuipment)list[list.Count() - 1];

            int lastId = Convert.ToInt32(temp4.ID);

            for (int i = 0; i < 4 - lastId.ToString().Length; i++)
            {
                id += "0";
            }
            return id + (lastId + 1).ToString();
        }
    }

    }

