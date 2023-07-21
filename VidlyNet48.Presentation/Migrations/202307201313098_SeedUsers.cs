namespace VidlyNet48.Presentation.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class SeedUsers : DbMigration
	{
		public override void Up()
		{
			Sql(@"
				INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd926ae2f-e051-4fa2-bb2d-3b0aa5d37db2', N'CanManageMovies')
				
				INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1e13a29b-5d8d-42b3-a3d6-44133635e75d', N'admin@vidly.com', 0, N'AJccBOnnGT/4gIvElcM4qrLkr9VhITAfIAdQbcjHqTmbFPZc1ACdh8Au8h7vlf4sMw==', N'679305ee-f768-48fe-9697-102adc38c6a3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
				INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'33285ad9-6a8b-4f33-9006-244c8f27495e', N'guest@vidly.com', 0, N'AB59lkp+cxsHbSajuwCpBHsUId7CoZ/EDy7No695TriWyQ6Fkj7XgqwqkVImgxP1RQ==', N'49804171-50b2-4191-a547-0bc1320df795', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

				INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1e13a29b-5d8d-42b3-a3d6-44133635e75d', N'd926ae2f-e051-4fa2-bb2d-3b0aa5d37db2')
			");
		}
		
		public override void Down()
		{
		}
	}
}
