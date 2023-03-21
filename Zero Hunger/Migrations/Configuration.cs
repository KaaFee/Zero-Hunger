namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.UI.WebControls.Expressions;

    internal sealed class Configuration : DbMigrationsConfiguration<Zero_Hunger.EF.AssignmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Zero_Hunger.EF.AssignmentContext context)
        { //  This method will be called after migrating to the latest version.


            //for (int i = 0; i < 10; i++)
            //{
            //    context.Restaurants.AddOrUpdate(
            //        new EF.Models.Restaurant()
            //        {
            //            Name = Guid.NewGuid().ToString().Substring(0, 6),
            //            Location = Guid.NewGuid().ToString().Substring(5,10)
            //        }
            //        );
            //}

            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    context.Foods.AddOrUpdate(
            //        new EF.Models.Food()
            //        {
            //            Name = Guid.NewGuid().ToString().Substring(0, 15),
            //            Quantity = random.Next(0, 30),
            //            R_ID=random.Next(1,11)
            //        }
            //    );
            //}
        }
    }
}
