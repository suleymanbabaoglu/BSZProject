namespace MvcUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Sliders",
            //    c => new
            //    {
            //        SliderID = c.Int(nullable: false, identity: true),
            //        SliderIsActive = c.Boolean(nullable: false),
            //        SliderText1 = c.String(maxLength: 50, unicode: false),
            //        SliderText2 = c.String(maxLength: 50, unicode: false),
            //        SliderInformation = c.String(maxLength: 250, unicode: false),
            //        SliderOrder = c.Int(),
            //        SliderBackground = c.String(maxLength: 250, unicode: false),
            //        SliderLink1 = c.String(maxLength: 250, unicode: false),
            //        SliderLink2 = c.String(maxLength: 250, unicode: false),
            //        SliderLinkText1 = c.String(maxLength: 50, unicode: false),
            //        SliderLinkText2 = c.String(maxLength: 50, unicode: false),
            //        SliderPrice = c.Double(),
            //        SliderCurrency = c.String(maxLength: 50, unicode: false),
            //    })
            //    .PrimaryKey(t => t.SliderID);
        }

        public override void Down()
        {
           // DropTable("dbo.Sliders");
        }
    }
}
