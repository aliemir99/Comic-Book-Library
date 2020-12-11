
using System.Collections.Generic;
using System.Data;



namespace ComicBookFactories
{
     public interface IPersonnelRepo
    {

        DataSet GetPersonnelDetailDataSet(int personnelID);

        DataTable GetPersonnelsTable();

        DataTable GetFirstPersonnelsTable();

        int GetFirstPersonnelID();

        DataTable GetPersonnelTable(int personnelID);

        int Create(Personnel personnel);

        int Save(Personnel personnel);

        int Delete(int personnelID);

        Personnel GetPersonnel(int personnelID);

        List<Personnel> GetPersonnelList();
    }
}
