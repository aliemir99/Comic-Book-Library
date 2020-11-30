using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComicBookFactories
{
    public interface IComicBookRepo
    {
        int Create(ComicBook book);

        int Save(ComicBook book);

        int Delete(int bookID);

        ComicBook GetComicBook(int bookID);

        List<ComicBook> GetComicBooks();

        int GetFirstComicID();

        DataSet GetComicDetailDataSet(int comicID);
    }
    
}
