namespace PS1._VAZQUEZOSUNALAURAMICHELLE.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PS1._VAZQUEZOSUNALAURAMICHELLE.Models.EventDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PS1._VAZQUEZOSUNALAURAMICHELLE.Models.EventDbContext";
        }

        protected override void Seed(PS1._VAZQUEZOSUNALAURAMICHELLE.Models.EventDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
