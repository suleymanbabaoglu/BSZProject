namespace MvcUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Contact",
            //    c => new
            //    {
            //        Id = c.Int(nullable: false, identity: true),
            //        About_text = c.String(maxLength: 250, unicode: false),
            //        Address = c.String(maxLength: 250, unicode: false),
            //        Phone = c.String(maxLength: 50, unicode: false),
            //        Email = c.String(maxLength: 250, unicode: false),
            //        Instagram = c.String(maxLength: 50, unicode: false),
            //        Facebook = c.String(maxLength: 50, unicode: false),
            //        Google_plus = c.String(maxLength: 50, unicode: false)
            //    }).PrimaryKey(c => c.Id);

        }

        public override void Down()
        {
            //DropTable("dbo.Contact");
        }
    }
}
