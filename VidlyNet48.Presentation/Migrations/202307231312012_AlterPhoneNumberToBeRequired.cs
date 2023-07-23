using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class AlterPhoneNumberToBeRequired : DbMigration
	{
		public override void Up()
		{
			AlterColumn("dbo.AspNetUsers", "PhoneNumber", p =>
				p.String(nullable: false, maxLength: 50, defaultValue: ""));
		}
		
		public override void Down()
		{
			AlterColumn("dbo.AspNetUsers", "PhoneNumber", p =>
				p.String(nullable: true, maxLength: null, defaultValue: null));
		}
	}
}
