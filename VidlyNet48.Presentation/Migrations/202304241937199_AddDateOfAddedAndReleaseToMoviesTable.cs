namespace VidlyNet48.Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateOfAddedAndReleaseToMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
