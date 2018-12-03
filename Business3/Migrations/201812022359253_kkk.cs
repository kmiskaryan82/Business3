namespace Business3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kkk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "DoM", c => c.DateTime());
            AlterColumn("dbo.Vehicles", "RegDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "RegDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vehicles", "DoM", c => c.DateTime(nullable: false));
        }
    }
}
