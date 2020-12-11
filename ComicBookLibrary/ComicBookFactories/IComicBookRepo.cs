
using System.Collections.Generic;
using System.Data;



namespace ComicBookFactories
{
    public interface IComicBookRepo
    {
        int Create(ComicBook book);

        int Save(ComicBook book);

        int Delete(int bookID);

        int GetLastInsertedComicID();

        ComicBook GetComicBook(int bookID);

        List<ComicBook> GetComicBooks();

        int GetFirstComicID();

        DataSet GetComicDetailDataSet(int comicID);

        int linkPersonnelToComicBook(ComicBook book);
    }
    
}
