namespace Gp.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Gp.Data.GpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Gp.Data.GpContext";
        }

        protected override void Seed(Gp.Data.GpContext context)
        {
            context.Categories.AddOrUpdate(p=>p.Name,
                new Domain.Category() { Name = "Phone" }
                );
        }
    }
}
