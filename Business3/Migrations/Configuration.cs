namespace Business3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Business3.DataModel.BusinessContetx>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Business3.DataModel.BusinessContetx";
        }

        protected override void Seed(Business3.DataModel.BusinessContetx context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
