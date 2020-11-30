
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class sqlPreFilledTables
    {

        public DataTable getPublishersTable()
        {
            var sqlGetPublishers = "SELECT * FROM Publisher";
            var cmd = new SqlCommand(sqlGetPublishers);

            var dt = DataAccess.GetDataTable(cmd);
        
            return dt;
        }

        public DataTable getGenresTable()
        {
            var sqlGetGenres = "SELECT * FROM Genre ORDER BY GenreName";
            var cmd = new SqlCommand(sqlGetGenres);

            var dt = DataAccess.GetDataTable(cmd);

            return dt;
        }
   

        public DataTable getRolesTable()
        {
            var sqlGetRoles= "SELECT * FROM Role";
            var cmd = new SqlCommand(sqlGetRoles);

            var dt = DataAccess.GetDataTable(cmd);

            return dt;
        }

        public DataTable getRatingsTable()
        {
            var sqlGetRatings = "SELECT * FROM Rating";
            var cmd = new SqlCommand(sqlGetRatings);

            var dt = DataAccess.GetDataTable(cmd);

            return dt;
        }


    }
}
