using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicBookFactories;

namespace DataAccess
{
    public static class PersonnelExtension
    {
        public static List<Personnel> ConvertToPersonnelList(this DataTable dt)
        {
            var personnelList = new List<Personnel>();

            foreach (DataRow row in dt.Rows)
            {
                var personnel = row.ConvertToPersonnel();
                personnelList.Add(personnel);
            }
            return personnelList;
        }
        public static Personnel ConvertToPersonnel(this DataTable dt)
        {
            var dr = dt.Rows[0];
            return dr.ConvertToPersonnel();
        }

        public static Personnel ConvertToPersonnel(this DataRow dr)
        {
            var personnel = new Personnel();

            personnel.PersonnelID = Convert.ToInt32(dr["PersonnelID"]);
            personnel.FirstName = dr["FirstName"].ToString();
            personnel.LastName = dr["LastName"].ToString();
            personnel.DateOfBirth = Convert.ToDateTime(dr["DateOFBirth"]);


            return personnel;
        }

        public static List<string> Validate(Personnel personnel)
        {
            List<string> errorList = new List<string>();
            if (string.IsNullOrEmpty(personnel.FirstName))
            {
                errorList.Add("First name of the personnel cannot be empty.");
            }
            if (string.IsNullOrEmpty(personnel.LastName))
            {
                errorList.Add("Last name of the personnel cannot be empty.");
            }
            return errorList;
        }
    }
}
