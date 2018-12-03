namespace Business3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdMigraion681 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "RegDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "RegDate", c => c.String());
        }
    }
}
