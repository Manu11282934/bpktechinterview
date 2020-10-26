namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication5.Models.WebApplication5Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication5.Models.WebApplication5Context context)
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
            context.Employees.AddOrUpdate(p => p.EmpId,
                new Models.Employee { FirstName = "Product 1", LastName = "Category 1", City = "hyd" ,PhoneNumber="8501922389"},
                new Models.Employee { FirstName = "Product 2", LastName = "Category 2", City = "hyd" },
                new Models.Employee { FirstName = "Product 3", LastName = "Category 3", City = "hyd" }
                );
        }
    }
}
