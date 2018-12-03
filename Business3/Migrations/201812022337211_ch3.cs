namespace Business3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ch3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        ModelName = c.String(maxLength: 50),
                        V_color = c.String(maxLength: 50),
                        VIN = c.Long(nullable: false),
                        DoM = c.DateTime(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
