USE [ComicBookLibrary]
GO
/****** Object:  Table [dbo].[ComicBook]    Script Date: 2020-11-30 11:23:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComicBook](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [varchar](max) NOT NULL,
	[BookDescription] [varchar](max) NULL,
	[Author] [varchar](max) NOT NULL,
	[Designer] [varchar](max) NOT NULL,
	[PublishDate] [date] NOT NULL,
	[GenreID] [int] NOT NULL,
	[RatingID] [int] NOT NULL,
	[PublisherID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 2020-11-30 11:23:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Link_Personnel_to_ComicBook]    Script Date: 2020-11-30 11:23:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Link_Personnel_to_ComicBook](
	[PersonnelID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[RoleID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2020-11-30 11:23:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](max) NOT NULL,
	[Password] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personnel]    Script Date: 2020-11-30 11:23:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personnel](
	[PersonnelID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](max) NOT NULL,
	[LastName] [varchar](max) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonnelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 2020-11-30 11:23:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[PublisherID] [int] IDENTITY(1,1) NOT NULL,
	[PublisherName] [varchar](max) NOT NULL,
	[PublisherDescription] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 2020-11-30 11:23:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[RatingID] [int] IDENTITY(1,1) NOT NULL,
	[RatingName] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 2020-11-30 11:23:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ComicBook] ON 

INSERT [dbo].[ComicBook] ([BookID], [BookName], [BookDescription], [Author], [Designer], [PublishDate], [GenreID], [RatingID], [PublisherID]) VALUES (1, N'Saga', N'one of the best comic book ever', N'17', N'13', CAST(N'2020-11-21' AS Date), 6, 5, 1)
INSERT [dbo].[ComicBook] ([BookID], [BookName], [BookDescription], [Author], [Designer], [PublishDate], [GenreID], [RatingID], [PublisherID]) VALUES (2, N'Batman', N'this one is the best batman ever', N'10', N'15', CAST(N'2009-06-23' AS Date), 1, 4, 2)
INSERT [dbo].[ComicBook] ([BookID], [BookName], [BookDescription], [Author], [Designer], [PublishDate], [GenreID], [RatingID], [PublisherID]) VALUES (5, N'superman', N'asfdghhgjhgffsdf', N'16', N'13', CAST(N'2020-11-21' AS Date), 1, 4, 2)
SET IDENTITY_INSERT [dbo].[ComicBook] OFF
GO
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (1, N'Superhero')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (2, N'Manga')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (3, N'Slice-of-Life')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (4, N'Humor')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (5, N'Non-fiction')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (6, N'Science-Fiction/Fantasy')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (7, N'Horror')
SET IDENTITY_INSERT [dbo].[Genre] OFF
GO
SET IDENTITY_INSERT [dbo].[Personnel] ON 

INSERT [dbo].[Personnel] ([PersonnelID], [FirstName], [LastName], [DateOfBirth]) VALUES (10, N'Oswald', N'Farmer', CAST(N'1999-01-01' AS Date))
INSERT [dbo].[Personnel] ([PersonnelID], [FirstName], [LastName], [DateOfBirth]) VALUES (13, N'jeremy', N'craig', CAST(N'1999-01-01' AS Date))
INSERT [dbo].[Personnel] ([PersonnelID], [FirstName], [LastName], [DateOfBirth]) VALUES (15, N'denisse', N'target', CAST(N'1999-01-01' AS Date))
INSERT [dbo].[Personnel] ([PersonnelID], [FirstName], [LastName], [DateOfBirth]) VALUES (16, N'Garet', N'Johnson', CAST(N'1999-01-13' AS Date))
INSERT [dbo].[Personnel] ([PersonnelID], [FirstName], [LastName], [DateOfBirth]) VALUES (17, N'Brian K.', N'Vaugn', CAST(N'1977-01-13' AS Date))
SET IDENTITY_INSERT [dbo].[Personnel] OFF
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 

INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (1, N'Dark Horse Comics', N'Dark Horse Comics is an American comic book and manga publisher. It was founded in 1986 by Mike Richardson in Milwaukie, Oregon. 
	Richardson started out by opening his first comic book store, Pegasus Books, in Bend, Oregon, in 1980.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (2, N'DC Entertainment', N'C Comics, Inc. is an American comic book publisher. It is the publishing unit of DC Entertainment, a subsidiary of the Warner Bros.
	Global Brands and Experiences division of Warner Bros., a subsidiary of AT&T''s WarnerMedia''s Studios & Networks division.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (3, N'Image Comics', N'Image Comics is an American comic book publisher and is the third largest comic book and graphic novel publisher in the industry in both unit and market share.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (4, N'Top Cow', N'Top Cow Productions is an American comics publisher, a partner studio of Image Comics founded by Marc Silvestri in 1992.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (5, N'Marvel', N'Marvel Comics is the brand name and primary imprint of Marvel Worldwide Inc., formerly Marvel Publishing, Inc. and Marvel Comics Group, a publisher of American comic books and related media.
	In 2009, The Walt Disney Company acquired Marvel Entertainment, Marvel Worldwide''s parent company.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (6, N'2000 AD', N'2000 AD is a weekly British science fiction-oriented comic magazine. As a comics anthology it serialises stories in each issue and was first published by IPC Magazines in 1977,
	the first issue dated 26 February.Since 2000 it has been published by Rebellion Developments. ')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (7, N'215 Ink', N'215 Ink is a publishing company that publishes comics')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (8, N'AAM Markosia', N'AAM Markosia is a publishing company that publishes comics')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (9, N'Action Lab Comics', N'Action Lab Entertainment, is an American publisher of comic books, known primarily for the publication of the all-ages fantasy title Princeless, as well as a wide range of titles from all genres.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (10, N'Aftershock Comics', N'AfterShock Comics is an American comic book publisher launched in 2015. AfterShock is described as a
	“hybrid comic book company combining the creative edge of an independent comic book publisher with the strengths and experience of a traditional powerhouse."')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (11, N'Ahoy Comics', N'Ahoy Comics is an American comic book publisher. It was founded in 2018 by publisher Hart Seely, editors Tom Peyer and Stuart Moore, and chief creative officer Frank Cammuso.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (12, N'Alterna Comics', N'Alterna Comics is a publishing company that publishes comics')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (13, N'Antarctic Press', N'Antarctic Press is a San Antonio-based comic book publishing company which publishes "Amerimanga" style comic books.
	The company also produces "how-to" and "you can" comics, instructing on areas of comic book creation and craft.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (14, N'Avatar Press', N'Avatar Press is an independent American comic book publisher founded in 1996 by William A. Christensen, and based in Rantoul, Illinois.
	Avatar Press is most notable for publishing Bad Girl comics, such as Faust, Pandora, Hellina, Lookers, The Ravening, and Brian Pulido''s Lady Death.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (15, N'Benitez Productions', N'Joe Benitez is an American comic book artist. He is co-creator and penciller of Weapon Zero, published by Top Cow Productions.
	Other titles he has worked on include The Darkness, The Magdalena, as well as work for DC Comics. ')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (16, N'BHP Comics', N'Book publisher in Glasgow, Scotland')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (17, N'Black Mask Studios', N'Black Mask Studios is a comic book and graphic novel publishing company formed by Matt Pizzolo,
	Steve Niles and Brett Gurewitz, designed as a new infrastructure to support comic book creators and a new pipeline for transgressive art.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (18, N'Blue Fox Comics', N'Blue Fox Comics is a small publishing company based off UK')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (19, N'Boom Studios', N'Boom! Studios is an American comic book and graphic novel publisher, headquartered in Los Angeles, California, United States.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (20, N'Caliber Comics', N'Caliber Comics or Caliber Press is an American comic book publisher founded in 1989 by Gary Reed. Featuring primarily creator-owned comics,
	Caliber published over 1,300 comics in the decade following its inception and is ranked as one of America''s leading independent publishers.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (21, N'Comics Experience Publishing', N'Comics Experience is an online resource for people who want to learn how to publish their own comics')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (22, N'Committed Comics', N'Committed Comics is an independent comic company that has been creating high quality comics for over a decade!
	Committed Comics specializes in giving talented creators the opportunity to bring their projects to the people.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (23, N'Dead Reckoning', N'Dead Reckoning is a publisher of graphic novels and an imprint of the Naval Institute Press located in Annapolis, Maryland.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (24, N'Deadstar Publishing', N'Based in Cardiff, Wales, we specialise in publishing works of fantasy, science fiction and horror from artists and writers all over the world.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (25, N'Dynamite Entertainment', N'Dynamite Entertainment is an American comic book publishing imprint of Dynamic Forces that primarily publishes adaptations of franchises from other media.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (26, N'Golden Liberty Comics', N'Golden Bell Studios was formed with the hope of merging new and classic content to create timeless experiences for consumers of entertainment.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (27, N'Heavy Metal', N'Heavy Metal is an American science fiction and fantasy comics magazine, published beginning in 1977. 
	The magazine is known primarily for its blend of dark fantasy/science fiction and erotica and steampunk comics.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (28, N'Hound Comics', N'Hound Comics is a privately owned publishing company dedicated to providing top notch entertainment including several projects ranging from comic books to film.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (29, N'Humanoids', N'Humanoids began under the name Les Humanoïdes Associés in the turbulent early 1970s in Paris, which—like San Francisco and New York—was alive with the spirit of artistic revolution.
	As young people were debating ideas in unprecedented ways, graphic novel artists Jean Giraud (known as Mœbius) and Philippe Druillet,
	along with writer Jean-Pierre Dionnet were determined to push the limits of their art and of the medium as a whole.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (30, N'Lady Death Universe', N'Created in 1991 by writer Brian Pulido, Lady Death was originally a teenaged girl named Hope who is deceived by demons and trades her mortality for eternal life in Hell.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (31, N'Lion Forge Comics', N'Lion Forge Comics is an American comic book publisher founded in 2011 by David Steward II and Carl Reed, with headquarters located in St. Louis, Missouri.
	 The company has a strong focus on culturally diverse creators and stories.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (32, N'Red 5 Comics', N'Red 5 is an independent comic book publisher, known for producing a combination of creator-owned and internally developed titles, including their best known title, Atomic Robo.
	Red 5 was one of the first comics publishers to jump into digital distribution.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (33, N'Red Giant Entertainment', N'Red Giant Entertainment, Inc. is a Florida-headquartered comic book publisher and "transmedia" entertainment company first established in 2010.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (34, N'Scout Comics', N'We develop and publish creator-owned comics. By consistently bringing exciting new, talented voices and their Intellectual Property to market, 
	 we have established ourselves as a pipeline to major studios and producers for some the of best new characters,
	 ripe for development in TV, Film, Digital, Mobile, VR, and video games.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (35, N'Stranger Comics', N'Guided by president Sebastian A. Jones, Stranger Comics is an incubator and aggregator of content, developing and designing franchises for multi-media platforms.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (36, N'Timebomb Comics', N'Time Bomb Comics is a British comics company that publishes comics and graphic novels, including the popular Flintlock and Brawler anthology series')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (37, N'Titan Comics', N'Titan Comics is a bold new publishing initiative from Titan Publishing, offering readers the best new stories from new and established comics creators.')
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherDescription]) VALUES (38, N'Valiant Entertainment', N'Valiant Comics is an American publisher of comic books and related media.
	The company was founded in 1989 by former Marvel Comics editor-in-chief Jim Shooter along with lawyer and businessman Steven Massarsky.
	In 1994, the company was sold to Acclaim Entertainment.')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
SET IDENTITY_INSERT [dbo].[Rating] ON 

INSERT [dbo].[Rating] ([RatingID], [RatingName]) VALUES (2, N'All Ages')
INSERT [dbo].[Rating] ([RatingID], [RatingName]) VALUES (3, N'Teen')
INSERT [dbo].[Rating] ([RatingID], [RatingName]) VALUES (4, N'Teens and up')
INSERT [dbo].[Rating] ([RatingID], [RatingName]) VALUES (5, N'Parental Advisory')
INSERT [dbo].[Rating] ([RatingID], [RatingName]) VALUES (6, N'Explicit Content')
SET IDENTITY_INSERT [dbo].[Rating] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Author')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Art Designer')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
ALTER TABLE [dbo].[ComicBook]  WITH CHECK ADD FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genre] ([GenreID])
GO
ALTER TABLE [dbo].[ComicBook]  WITH CHECK ADD FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([PublisherID])
GO
ALTER TABLE [dbo].[ComicBook]  WITH CHECK ADD FOREIGN KEY([RatingID])
REFERENCES [dbo].[Rating] ([RatingID])
GO
ALTER TABLE [dbo].[Link_Personnel_to_ComicBook]  WITH CHECK ADD FOREIGN KEY([BookID])
REFERENCES [dbo].[ComicBook] ([BookID])
GO
ALTER TABLE [dbo].[Link_Personnel_to_ComicBook]  WITH CHECK ADD FOREIGN KEY([PersonnelID])
REFERENCES [dbo].[Personnel] ([PersonnelID])
GO
ALTER TABLE [dbo].[Link_Personnel_to_ComicBook]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
