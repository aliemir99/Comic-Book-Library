using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ComicBookFactories;
namespace DataAccess
{

    public class SqlComicBook : IComicBookRepo
    {
        public int Create(ComicBook book)
        {
            var sqlInsertComic = "INSERT INTO ComicBook Values(@BookName, @BookDescription, @Author, @Designer, @PublishDate, @GenreID, @RatingID, @PublisherID)";
            var cmd = new SqlCommand(sqlInsertComic);

            cmd.Parameters.AddWithValue("@BookName", book.Name);
            cmd.Parameters.AddWithValue("@BookDescription", book.Description);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@Designer", book.Designer);
            cmd.Parameters.AddWithValue("@PublishDate", book.PublishDate);
            cmd.Parameters.AddWithValue("@GenreID", book.GenreID);
            cmd.Parameters.AddWithValue("@RatingID", book.RatingID);
            cmd.Parameters.AddWithValue("@PublisherID", book.PublisherID);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            book.BookID = GetLastInsertedComicID();
            linkPersonnelToComicBook(book);

            return rowsAffected;
        }

        public int Delete(int bookID)
        {
            var sqlDeleteComic = "DELETE ComicBook WHERE BookID =@BookID";
            var cmd = new SqlCommand(sqlDeleteComic);

            cmd.Parameters.AddWithValue("@BookID", bookID);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

        public ComicBook GetComicBook(int bookID)
        {
            var ComicBooks = GetComicBooks();
            foreach (ComicBook book in ComicBooks)
            {
                if (book.BookID.Equals(bookID))
                {
                    return book;
                }

            }
            return new ComicBook();
        }
        public int GetFirstComicID()
        {
            var sqlComics = $"SELECT TOP (1) BookID FROM ComicBook ORDER BY BookID";
            var cmd = new SqlCommand(sqlComics);
            var comicID = DataAccess.ExecuteScalar(cmd);
            return Convert.ToInt32(comicID);
        }

        public List<ComicBook> GetComicBooks()
        {
            var sqlGetComics = "SELECT * FROM ComicBook";
            var cmd = new SqlCommand(sqlGetComics);

            var dt = DataAccess.GetDataTable(cmd);
            var ComicBooks = ComicBookExtension.ConvertToComicBooks(dt);

            return ComicBooks;

        }

        public int Save(ComicBook book)
        {
            string sqlUpdateComic = "UPDATE ComicBook SET" +
                " BookName = @BookName," +
                " BookDescription = @BookDescription," +
                "Author = @Author," +
                "Designer = @Designer," +
                "PublishDate = @PublishDate," +
                "GenreID = @GenreID, " +
                "RatingID = @RatingID, " +
                "PublisherID = @PublisherID " +
                "WHERE BookID= @BookID";

            var cmd = new SqlCommand(sqlUpdateComic);

            cmd.Parameters.AddWithValue("@BookID", book.BookID);
            cmd.Parameters.AddWithValue("@BookName", book.Name);
            cmd.Parameters.AddWithValue("@BookDescription", book.Description);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@Designer", book.Designer);
            cmd.Parameters.AddWithValue("@PublishDate", book.PublishDate);
            cmd.Parameters.AddWithValue("@GenreID", book.GenreID);
            cmd.Parameters.AddWithValue("@RatingID", book.RatingID);
            cmd.Parameters.AddWithValue("@PublisherID", book.PublisherID);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

        public DataSet GetComicDetailDataSet(int comicID)
        {
            var sqlComic =
            $@"SELECT * FROM ComicBook WHERE BookID = @BookID;
            SELECT 
            (
                SELECT TOP(1) BookID as firstComicID FROM ComicBook ORDER BY BookID
            ) as firstComicID,
            q.previousComicID,
            q.nextComicID,
            (
                SELECT TOP(1) BookID as lastComicID FROM ComicBook ORDER BY BookID Desc
            ) as lastComicID
            FROM
            (
            SELECT BookID, BookName,
            LEAD(BookID) OVER(ORDER BY BookID) AS nextComicID,
            LAG(BookID) OVER(ORDER BY BookID) AS previousComicID,
                ROW_NUMBER() OVER(ORDER BY BookID) AS 'RowNumber'
                FROM ComicBook
            ) AS q
            WHERE q.BookID = @BookID
            ORDER BY q.BookID".Replace(Environment.NewLine, string.Empty);
            var cmd = new SqlCommand(sqlComic);
            cmd.Parameters.AddWithValue("@BookID", comicID);
            var ds = DataAccess.GetDataSet(cmd);
            return ds;
        }

        public int GetLastInsertedComicID()
        {
            var sqlString = "SELECT TOP(1)BookID FROM ComicBook ORDER BY BookID DESC";
            var cmd = new SqlCommand(sqlString);
            var requestedValue = DataAccess.ExecuteScalar(cmd);
            return Convert.ToInt32(requestedValue);

        }

        public int linkPersonnelToComicBook(ComicBook book)
        {
            var sqlString = "EXEC dbo.LinkPersonnelToComicBook @bookID,@authorID,@designerID";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@bookID", book.BookID);
            cmd.Parameters.AddWithValue("@authorID", book.Author);
            cmd.Parameters.AddWithValue("@designerID", book.Designer);
            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }
    }
}
