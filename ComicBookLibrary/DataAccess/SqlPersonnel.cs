using ComicBookFactories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class SqlPersonnel : IPersonnelRepo
    {

        public DataSet GetPersonnelDetailDataSet(int personnelID)
        {
            var sqlPersonnel =
    $@"SELECT * FROM Personnel WHERE personnelID = @personnelID;
    SELECT 
    (
        SELECT TOP(1) personnelID as firstPersonnelID FROM Personnel ORDER BY personnelID
    ) as firstPersonnelID,
    q.previousPersonnelID,
    q.nextPersonnelID,
    (
        SELECT TOP(1) personnelID as lastPersonnelID FROM Personnel ORDER BY personnelID Desc
    ) as lastPersonnelID
    FROM
    (
    SELECT personnelID, FirstName,
    LEAD(personnelID) OVER(ORDER BY personnelID) AS nextPersonnelID,
    LAG(personnelID) OVER(ORDER BY personnelID) AS previousPersonnelID,
        ROW_NUMBER() OVER(ORDER BY personnelID) AS 'RowNumber'
        FROM Personnel
    ) AS q
    WHERE q.personnelID = @personnelID
    ORDER BY q.personnelID".Replace(Environment.NewLine, string.Empty);
            var cmd = new SqlCommand(sqlPersonnel);
            cmd.Parameters.AddWithValue("@personnelID", personnelID);
            var ds = DataAccess.GetDataSet(cmd);
            return ds;
        }
        public DataTable GetPersonnelsTable()
        {
            var sqlPersonnels = $"SELECT * FROM Personnel";
            var cmd = new SqlCommand(sqlPersonnels);
            var dt = DataAccess.GetDataTable(cmd);
            return dt;
        }
        public DataTable GetFirstPersonnelsTable()
        {
            var sqlPersonnels = $"SELECT TOP (1) * FROM Personnel ORDER BY PersonnelID";
            var cmd = new SqlCommand(sqlPersonnels);
            var dt = DataAccess.GetDataTable(cmd);
            return dt;
        }
        public int GetFirstPersonnelID()
        {
            var sqlPersonnels = $"SELECT TOP (1) personnelID FROM Personnel ORDER BY personnelID";
            var cmd = new SqlCommand(sqlPersonnels);
            var personnelID = DataAccess.ExecuteScalar(cmd);
            return Convert.ToInt32(personnelID);
        }
        public DataTable GetPersonnelTable(int personnelID)
        {
            var sqlPersonnels = $"SELECT * FROM Personnel Where personnelID = @personnelID";
            var cmd = new SqlCommand(sqlPersonnels);
            cmd.Parameters.AddWithValue("@personnelID", personnelID);
            var dt = DataAccess.GetDataTable(cmd);
            return dt;
        }

        public int Create(Personnel personnel)
        {
            var sqlInsertPersonnel = "INSERT INTO Personnel Values(@FirstName,@LastName,@DateOfBirth)";
            var cmd = new SqlCommand(sqlInsertPersonnel);

            cmd.Parameters.AddWithValue("@FirstName", personnel.FirstName);
            cmd.Parameters.AddWithValue("@LastName", personnel.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", personnel.DateOfBirth);


            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

        public int Delete(int personnelID)
        {
            var sqlDeletePersonnel = "DELETE Personnel WHERE PersonnelID =@PersonnelID";
            var cmd = new SqlCommand(sqlDeletePersonnel);

            cmd.Parameters.AddWithValue("@PersonnelID", personnelID);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }
        
        public Personnel GetPersonnel(int PersonnelID)
        {      
            var personnelList = GetPersonnelList();
            foreach (Personnel person in personnelList)
            {
                if (person.PersonnelID.Equals(PersonnelID))
                {
                    return person;
                }

            }
            return new Personnel();
        }

        public List<Personnel> GetPersonnelList()
        {
            var sqlGetPersonnelList = "SELECT * FROM Personnel";
            var cmd = new SqlCommand(sqlGetPersonnelList);

            var dt = DataAccess.GetDataTable(cmd);
            var PersonnelList = PersonnelExtension.ConvertToPersonnelList(dt);

            return PersonnelList;

        }

        public int Save(Personnel personnel)
        {
            string sqlUpdatePersonnel = $@"UPDATE Personnel SET
                 FirstName = @FirstName,
                 LastName = @LastName,
                DateOfBirth = @DateOfBirth
                WHERE PersonnelID = @PersonnelID";
      
            var cmd = new SqlCommand(sqlUpdatePersonnel);
            cmd.Parameters.AddWithValue("@PersonnelID", personnel.PersonnelID);
            cmd.Parameters.AddWithValue("@FirstName", personnel.FirstName);
            cmd.Parameters.AddWithValue("@LastName", personnel.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", personnel.DateOfBirth);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

    }
}

