namespace VidlyNet48.Presentation.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class PopulateGenres : DbMigration
	{
		public override void Up()
		{
			Sql("INSERT INTO Genres (Name) VALUES ('Action')");
			Sql("INSERT INTO Genres (Name) VALUES ('Adventure')");
			Sql("INSERT INTO Genres (Name) VALUES ('Animation')");
			Sql("INSERT INTO Genres (Name) VALUES ('Biography')");
			Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
			Sql("INSERT INTO Genres (Name) VALUES ('Crime')");
			Sql("INSERT INTO Genres (Name) VALUES ('Documentary')");
			Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
			Sql("INSERT INTO Genres (Name) VALUES ('Family')");
			Sql("INSERT INTO Genres (Name) VALUES ('Fantasy')");
			Sql("INSERT INTO Genres (Name) VALUES ('History')");
			Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
			Sql("INSERT INTO Genres (Name) VALUES ('Musical')");
			Sql("INSERT INTO Genres (Name) VALUES ('Mystery')");
			Sql("INSERT INTO Genres (Name) VALUES ('News')");
			Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
			Sql("INSERT INTO Genres (Name) VALUES ('Science fiction')");
			Sql("INSERT INTO Genres (Name) VALUES ('Sport')");
			Sql("INSERT INTO Genres (Name) VALUES ('Thriller')");
			Sql("INSERT INTO Genres (Name) VALUES ('War')");
			Sql("INSERT INTO Genres (Name) VALUES ('Western')");
		}
		
		public override void Down()
		{
		}
	}
}
