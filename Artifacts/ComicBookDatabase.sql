
CREATE DATABASE ComicBookLibrary;

USE ComicBookLibrary;
GO
IF OBJECT_ID('Rating') IS NULL
	BEGIN
		CREATE TABLE Rating
		(
			RatingID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			RatingName VARCHAR(MAX) NOT NULL
		)
	END
IF OBJECT_ID('Genre') IS NULL
	BEGIN
		CREATE TABLE Genre
		(
			GenreID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			GenreName VARCHAR(MAX) NOT NULL
		)
	END
IF OBJECT_ID('Role') IS NULL
	BEGIN
		CREATE TABLE Role
		(
			RoleID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			RoleName VARCHAR(MAX) NOT NULL
		)
	END
IF OBJECT_ID('Personnel') IS NULL
	BEGIN
		CREATE TABLE Personnel
		(
			PersonnelID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			FirstName VARCHAR(MAX) NOT NULL,
			LastName VARCHAR(MAX) NOT NULL,
			DateOfBirth DATE NOT NULL,
		)
	END

IF OBJECT_ID('Publisher') IS NULL
	BEGIN
		CREATE TABLE Publisher
		(
			PublisherID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			PublisherName VARCHAR(MAX) NOT NULL,
			PublisherDescription VARCHAR(MAX) NULL
		)
	END

IF OBJECT_ID('Login') IS NULL
	BEGIN
		CREATE TABLE Login
		(
			UserID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			Username VARCHAR(MAX) NOT NULL,
			Password VARCHAR(MAX) NOT NULL
		)
	END


IF OBJECT_ID('ComicBook') IS NULL
	BEGIN
		CREATE TABLE ComicBook
		(
			BookID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			BookName VARCHAR(MAX) NOT NULL,
			BookDescription VARCHAR(MAX) NULL,
			Author VARCHAR(MAX) NOT NULL,
			Designer VARCHAR(MAX) NOT NULL,
			PublishDate DATE NOT NULL,
			GenreID INT NOT NULL,
			RatingID INT NOT NULL,
			PublisherID INT NOT NULL
			FOREIGN KEY (GenreID) REFERENCES Genre(GenreID),
			FOREIGN KEY (RatingID) REFERENCES Rating(RatingID),
			FOREIGN KEY (PublisherID) REFERENCES Publisher(PublisherID)
		)
	END

IF OBJECT_ID('Link_Personnel_to_ComicBook') IS NULL
	BEGIN
		CREATE TABLE Link_Personnel_to_ComicBook
		(
			PersonnelID INT NOT NULL,
			BookID INT NOT NULL,
			RoleID INT NOT NULL,
			FOREIGN KEY (PersonnelID) REFERENCES Personnel(PersonnelID),
			FOREIGN KEY (BookID) REFERENCES ComicBook(BookID),
			FOREIGN KEY (RoleID) REFERENCES Role(RoleID)
		)
	END

SELECT * FROM ComicBook;
SELECT * FROM Personnel;
SELECT * FROM Link_Personnel_to_ComicBook;
SELECT * FROM Genre;
SELECT * FROM Publisher;
SELECT * FROM Rating;
SELECT * FROM Role;
SELECT * FROM Login;

/*ROLE TABLE DATA*/
INSERT INTO Role
(RoleName)
VALUES
(
	'Author'
)
INSERT INTO Role
(RoleName)
VALUES
(
	'Art Designer'
)
/*GENRE TABLE DATA*/
INSERT INTO Genre
(GenreName)
VALUES
(
	'Superhero'
)
INSERT INTO Genre
(GenreName)
VALUES
(
	'Manga'
)

INSERT INTO Genre
(GenreName)
VALUES
(
	'Slice-of-Life'
)
INSERT INTO Genre
(GenreName)
VALUES
(
	'Humor'
)

INSERT INTO Genre
(GenreName)
VALUES
(
	'Non-fiction'
)
INSERT INTO Genre
(GenreName)
VALUES
(
	'Science-Fiction/Fantasy'
)
INSERT INTO Genre
(GenreName)
VALUES
(
	'Horror'
)
USE ComicBookLibrary
GO
/*RATING TABLE DATA*/
INSERT INTO Rating
(RatingName)
VALUES
(
	'All Ages'
)
INSERT INTO Rating
(RatingName)
VALUES
(
	'Teen'
)

INSERT INTO Rating
(RatingName)
VALUES
(
	'Teens and up'
)
INSERT INTO Rating
(RatingName)
VALUES
(
	'Parental Advisory'
)
INSERT INTO Rating
(RatingName)
VALUES
(
	'Explicit Content'
)
/* PUBLISHER TABLE DATA*/
SELECT * FROM Publisher

INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Dark Horse Comics',
	'Dark Horse Comics is an American comic book and manga publisher. It was founded in 1986 by Mike Richardson in Milwaukie, Oregon. 
	Richardson started out by opening his first comic book store, Pegasus Books, in Bend, Oregon, in 1980.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'DC Entertainment',
	'C Comics, Inc. is an American comic book publisher. It is the publishing unit of DC Entertainment, a subsidiary of the Warner Bros.
	Global Brands and Experiences division of Warner Bros., a subsidiary of AT&T''s WarnerMedia''s Studios & Networks division.'
)

INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Image Comics',
	'Image Comics is an American comic book publisher and is the third largest comic book and graphic novel publisher in the industry in both unit and market share.'
)

INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Top Cow',
	'Top Cow Productions is an American comics publisher, a partner studio of Image Comics founded by Marc Silvestri in 1992.'
)

INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Marvel',
	'Marvel Comics is the brand name and primary imprint of Marvel Worldwide Inc., formerly Marvel Publishing, Inc. and Marvel Comics Group, a publisher of American comic books and related media.
	In 2009, The Walt Disney Company acquired Marvel Entertainment, Marvel Worldwide''s parent company.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'2000 AD',
	'2000 AD is a weekly British science fiction-oriented comic magazine. As a comics anthology it serialises stories in each issue and was first published by IPC Magazines in 1977,
	the first issue dated 26 February.Since 2000 it has been published by Rebellion Developments. '
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'215 Ink',
	'215 Ink is a publishing company that publishes comics'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'AAM Markosia',
	'AAM Markosia is a publishing company that publishes comics'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Action Lab Comics',
	'Action Lab Entertainment, is an American publisher of comic books, known primarily for the publication of the all-ages fantasy title Princeless, as well as a wide range of titles from all genres.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Aftershock Comics',
	'AfterShock Comics is an American comic book publisher launched in 2015. AfterShock is described as a
	“hybrid comic book company combining the creative edge of an independent comic book publisher with the strengths and experience of a traditional powerhouse."'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Ahoy Comics',
	'Ahoy Comics is an American comic book publisher. It was founded in 2018 by publisher Hart Seely, editors Tom Peyer and Stuart Moore, and chief creative officer Frank Cammuso.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Alterna Comics',
	'Alterna Comics is a publishing company that publishes comics'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Antarctic Press',
	'Antarctic Press is a San Antonio-based comic book publishing company which publishes "Amerimanga" style comic books.
	The company also produces "how-to" and "you can" comics, instructing on areas of comic book creation and craft.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Avatar Press',
	'Avatar Press is an independent American comic book publisher founded in 1996 by William A. Christensen, and based in Rantoul, Illinois.
	Avatar Press is most notable for publishing Bad Girl comics, such as Faust, Pandora, Hellina, Lookers, The Ravening, and Brian Pulido''s Lady Death.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Benitez Productions',
	'Joe Benitez is an American comic book artist. He is co-creator and penciller of Weapon Zero, published by Top Cow Productions.
	Other titles he has worked on include The Darkness, The Magdalena, as well as work for DC Comics. '
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'BHP Comics',
	'Book publisher in Glasgow, Scotland'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Black Mask Studios',
	'Black Mask Studios is a comic book and graphic novel publishing company formed by Matt Pizzolo,
	Steve Niles and Brett Gurewitz, designed as a new infrastructure to support comic book creators and a new pipeline for transgressive art.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Blue Fox Comics',
	'Blue Fox Comics is a small publishing company based off UK'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Boom Studios',
	'Boom! Studios is an American comic book and graphic novel publisher, headquartered in Los Angeles, California, United States.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Caliber Comics',
	'Caliber Comics or Caliber Press is an American comic book publisher founded in 1989 by Gary Reed. Featuring primarily creator-owned comics,
	Caliber published over 1,300 comics in the decade following its inception and is ranked as one of America''s leading independent publishers.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Comics Experience Publishing',
	'Comics Experience is an online resource for people who want to learn how to publish their own comics'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Committed Comics',
	'Committed Comics is an independent comic company that has been creating high quality comics for over a decade!
	Committed Comics specializes in giving talented creators the opportunity to bring their projects to the people.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Dead Reckoning',
	'Dead Reckoning is a publisher of graphic novels and an imprint of the Naval Institute Press located in Annapolis, Maryland.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Deadstar Publishing',
	'Based in Cardiff, Wales, we specialise in publishing works of fantasy, science fiction and horror from artists and writers all over the world.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Dynamite Entertainment',
	'Dynamite Entertainment is an American comic book publishing imprint of Dynamic Forces that primarily publishes adaptations of franchises from other media.'
)

INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Golden Liberty Comics',
	'Golden Bell Studios was formed with the hope of merging new and classic content to create timeless experiences for consumers of entertainment.'
)

INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Heavy Metal',
	'Heavy Metal is an American science fiction and fantasy comics magazine, published beginning in 1977. 
	The magazine is known primarily for its blend of dark fantasy/science fiction and erotica and steampunk comics.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Hound Comics',
	'Hound Comics is a privately owned publishing company dedicated to providing top notch entertainment including several projects ranging from comic books to film.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Humanoids',
	'Humanoids began under the name Les Humanoïdes Associés in the turbulent early 1970s in Paris, which—like San Francisco and New York—was alive with the spirit of artistic revolution.
	As young people were debating ideas in unprecedented ways, graphic novel artists Jean Giraud (known as Mœbius) and Philippe Druillet,
	along with writer Jean-Pierre Dionnet were determined to push the limits of their art and of the medium as a whole.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Lady Death Universe',
	'Created in 1991 by writer Brian Pulido, Lady Death was originally a teenaged girl named Hope who is deceived by demons and trades her mortality for eternal life in Hell.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Lion Forge Comics',
	'Lion Forge Comics is an American comic book publisher founded in 2011 by David Steward II and Carl Reed, with headquarters located in St. Louis, Missouri.
	 The company has a strong focus on culturally diverse creators and stories.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Red 5 Comics',
	'Red 5 is an independent comic book publisher, known for producing a combination of creator-owned and internally developed titles, including their best known title, Atomic Robo.
	Red 5 was one of the first comics publishers to jump into digital distribution.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Red Giant Entertainment',
	'Red Giant Entertainment, Inc. is a Florida-headquartered comic book publisher and "transmedia" entertainment company first established in 2010.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Scout Comics',
	'We develop and publish creator-owned comics. By consistently bringing exciting new, talented voices and their Intellectual Property to market, 
	 we have established ourselves as a pipeline to major studios and producers for some the of best new characters,
	 ripe for development in TV, Film, Digital, Mobile, VR, and video games.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Stranger Comics',
	'Guided by president Sebastian A. Jones, Stranger Comics is an incubator and aggregator of content, developing and designing franchises for multi-media platforms.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Timebomb Comics',
	'Time Bomb Comics is a British comics company that publishes comics and graphic novels, including the popular Flintlock and Brawler anthology series'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Titan Comics',
	'Titan Comics is a bold new publishing initiative from Titan Publishing, offering readers the best new stories from new and established comics creators.'
)
INSERT INTO Publisher
(PublisherName, PublisherDescription)
VALUES
(
	'Valiant Entertainment',
	'Valiant Comics is an American publisher of comic books and related media.
	The company was founded in 1989 by former Marvel Comics editor-in-chief Jim Shooter along with lawyer and businessman Steven Massarsky.
	In 1994, the company was sold to Acclaim Entertainment.'
)
