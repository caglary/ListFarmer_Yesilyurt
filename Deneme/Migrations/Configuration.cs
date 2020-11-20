namespace Deneme.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Deneme.Database.Context.YesilyurtDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;   
            AutomaticMigrationDataLossAllowed=true;
            ContextKey = "Deneme.Database.Context.YesilyurtDbContext";
        }

        protected override void Seed(Deneme.Database.Context.YesilyurtDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
