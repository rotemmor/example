namespace example.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<example.DAL.WebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

       
    }
}
