namespace Business3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fgf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Phone", c => c.Long(nullable: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 20));
            AlterColumn("dbo.Customers", "Vehicle", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Vehicle", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
        }
    }
}
