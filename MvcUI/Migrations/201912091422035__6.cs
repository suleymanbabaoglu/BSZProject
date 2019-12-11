namespace MvcUI.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Settings", "prices_isactive", c => c.Boolean());
        }
        
        public override void Down()
        {
            
        }
    }
}
