namespace MvcUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _61 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Settings", "prices_isactive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Settings", "prices_isactive", c => c.Binary(maxLength: 1, fixedLength: true));
        }
    }
}
