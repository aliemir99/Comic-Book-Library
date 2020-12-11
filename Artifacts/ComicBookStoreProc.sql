USE ComicBookLibrary;
GO

SELECT * FROM Link_Personnel_to_ComicBook;

SELECT TOP(1)BookID FROM ComicBook ORDER BY BookID DESC;

SELECT * FROM ComicBook
SELECT * FROM Personnel
SELECT * FROM Role;

USE ComicBookLibrary;
GO
CREATE OR ALTER PROCEDURE dbo.LinkPersonnelToComicBook
@bookID INT,@authorID INT,@designerID INT
AS
	BEGIN
		BEGIN
			INSERT INTO Link_Personnel_to_ComicBook
			VALUES(@authorID,@bookID,1);
		END
		BEGIN
			INSERT INTO Link_Personnel_to_ComicBook
			VALUES(@designerID,@bookID,2);
		END
	END



	--EXEC dbo.LinkPersonnelToComicBook 1,17,13
