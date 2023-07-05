namespace VidlyNet48.Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberInStuckToMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStuck", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberInStuck");
        }
    }
}
