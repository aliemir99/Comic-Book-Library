using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicBookFactories;

namespace DataAccess
{
    public static class ComicBookExtension
    {
        public static List<ComicBook> ConvertToComicBooks(this DataTable dt)
        {
            var books = new List<ComicBook>();

            foreach (DataRow row in dt.Rows)
            {
                var book = row.ConvertToComicBook();
                books.Add(book);
            }
            return books;
        }
        public static ComicBook ConvertToComicBook(this DataTable dt)
        {
            var dr = dt.Rows[0];
            return dr.ConvertToComicBook();
        }

        public static ComicBook ConvertToComicBook(this DataRow dr)
        {
            var book = new ComicBook();

            book.BookID =Convert.ToInt32(dr["BookID"]);
            book.Name = dr["BookName"].ToString();
            book.Description = dr["BookDescription"].ToString();
            book.Author = dr["Author"].ToString();
            book.Designer = dr["Designer"].ToString();
            book.PublishDate = Convert.ToDateTime(dr["PublishDate"]);
            book.GenreID = dr["GenreID"].ToString();
            book.RatingID =dr["RatingID"].ToString();
            book.PublisherID= dr["PublisherID"].ToString();

            return book;
        }
        public static List<string> Validate(ComicBook book)
        {
            List<string> errorList = new List<string>();
            if (string.IsNullOrEmpty(book.Name)){
                errorList.Add("Name of the book cannot be empty.");
            }
            if (string.IsNullOrEmpty(book.Description))
            {
                errorList.Add("Description of the book cannot be empty.");
            }
            if (string.IsNullOrEmpty(book.Author))
            {
                errorList.Add("Author of the book cannot be empty.");
            }
            if (string.IsNullOrEmpty(book.Designer))
            {
                errorList.Add("Designer of the book cannot be empty.");
            }
            if (string.IsNullOrEmpty(book.GenreID))
            {
                errorList.Add("Genre of the book cannot be empty.");
            }
            if (string.IsNullOrEmpty(book.RatingID))
            {
                errorList.Add("Rating of the book cannot be empty.");
            }
            if (string.IsNullOrEmpty(book.PublisherID))
            {
                errorList.Add("Publisher of the book cannot be empty.");
            }
            return errorList;
        }



    }
}
