using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Zero_Hunger.EF.Models;

namespace Zero_Hunger.EF
{
    public class AssignmentContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeFoodReq> EmployeeFoodReqs { get; set; }
        public DbSet<FoodRequest> FoodRequests { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<CollectRequest> CollectRequests { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}