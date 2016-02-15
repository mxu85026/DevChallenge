namespace Mentor_DevChallenge.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mentor_DevChallenge.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mentor_DevChallenge.Models.ApplicationDbContext context)
        {
            var tabTitles = new TabTitles[] {
                new TabTitles {
                    Title = "Dr. Shurt's Office"
                },
                new TabTitles {
                    Title = "Hillsboro"
                }
            };
            context.TabTitles.AddOrUpdate(t => t.Title, tabTitles);

            var primaryCare = new PrimaryProviders[] {
                new PrimaryProviders {
                    Name = "Dr. Shurt's Office"
                },
                new PrimaryProviders {
                    Name = "Rose City Clinic"
                },
                new PrimaryProviders {
                    Name = "Hillsboro Northside"
                }
            };
            context.PrimaryProvidersS.AddOrUpdate(p => p.Name, primaryCare);
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
        }
    }
}
