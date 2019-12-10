namespace MvcUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.settings", "keywords", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Users", "RememberMe");
        }
    }
}
