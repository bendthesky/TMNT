namespace TMNT.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TMNT.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TMNT.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TMNT.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.NinjaTurtles.AddOrUpdate(
                t => t.Name,
                new NinjaTurtle { Name = "Ted", Weapon = "His slow nature", Picture = "http://www.ecology.com/wp-content/uploads/2012/05/eastern-box-turtle.jpg", Description = "He's a turtle goddammit, what else do I need to tell you?" }
                );
        }
    }
}
