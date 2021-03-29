namespace ConsoleApp.MS_SQL_and_ENTITY_FRAMEWORK.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApp.MS_SQL_and_ENTITY_FRAMEWORK.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleApp.MS_SQL_and_ENTITY_FRAMEWORK.MyDbContext";
        }

        protected override void Seed(ConsoleApp.MS_SQL_and_ENTITY_FRAMEWORK.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
