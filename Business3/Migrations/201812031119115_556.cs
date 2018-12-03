namespace Business3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _556 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DoB", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DoB", c => c.String());
        }
    }
}
