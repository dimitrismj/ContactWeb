namespace ContactWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactWeb.Models.ContactWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ContactWeb.Models.ContactWebContext";
        }

        protected override void Seed(ContactWeb.Models.ContactWebContext context)
        {
            /* 05917237-0235-49a6-9913-17ec97f4ab5c
             * 2eca5b3e-3fa6-4232-810b-5bfb2b94d849
             */
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

            context.Contacts.AddOrUpdate(
                p => p.Id,
                new Models.Contact
                {
                    Id = 1,
                    Birthday = new DateTime(1920, 01, 20),
                    City = "Chicago"
                                    ,
                    Email = "doc.mccoy@starfleet.com",
                    FirstName = "DeForest",
                    LastName = "Kelley"
                                    ,
                    PhonePrimary = "123-456-7890",
                    PhoneSecondary = "234-567-8901",
                    State = "IL"
                                    ,
                    StreetAddress1 = "Sickbay",
                    StreetAddress2 = "Starship Enterprise NCC-1701"
                                    ,
                    UserId = new Guid("05917237-0235-49a6-9913-17ec97f4ab5c")
                                    ,
                    Zip = "98765"
                }
                , new Models.Contact
                {
                    Id = 2,
                    Birthday = new DateTime(1920, 03, 03),
                    City = "New York"
                                    ,
                    Email = "i.beam.you.up@starfleet.com",
                    FirstName = "James",
                    LastName = "Doohan"
                                    ,
                    PhonePrimary = "345-678-9012",
                    PhoneSecondary = "456-789-0123",
                    State = "NY"
                                    ,
                    StreetAddress1 = "Engineering",
                    StreetAddress2 = "Starship Enterprise NCC-1701"
                                    ,
                    UserId = new Guid("05917237-0235-49a6-9913-17ec97f4ab5c")
                                    ,
                    Zip = "87654"
                }
                , new Models.Contact
                {
                    Id = 3,
                    Birthday = new DateTime(1931, 03, 26),
                    City = "Los Angeles"
                                    ,
                    Email = "its.only.logic@starfleet.com",
                    FirstName = "Leonard",
                    LastName = "Nimoy"
                                    ,
                    PhonePrimary = "987-654-3210",
                    PhoneSecondary = "876-543-2109",
                    State = "CA"
                                    ,
                    StreetAddress1 = "Science Station 1",
                    StreetAddress2 = "Starship Enterprise NCC-1701"
                                    ,
                    UserId = new Guid("2eca5b3e-3fa6-4232-810b-5bfb2b94d849")
                                    ,
                    Zip = "76543-2109"
                }
                , new Models.Contact
                {
                    Id = 4,
                    Birthday = new DateTime(1931, 03, 22),
                    City = "Riverside"
                                    ,
                    Email = "the.captain@starfleet.com",
                    FirstName = "William",
                    LastName = "Shatner"
                                    ,
                    PhonePrimary = "765-432-1098",
                    PhoneSecondary = "654-321-0987",
                    State = "IA"
                                    ,
                    StreetAddress1 = "The Bridge",
                    StreetAddress2 = "Starship Enterprise NCC-1701"
                                    ,
                    UserId = new Guid("2eca5b3e-3fa6-4232-810b-5bfb2b94d849")
                                    ,
                    Zip = "65432-0123"
                }
            );
        }
    }
}
