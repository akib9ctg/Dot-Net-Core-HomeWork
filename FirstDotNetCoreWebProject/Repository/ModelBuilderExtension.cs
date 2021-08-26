using FirstDotNetCoreWebProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDotNetCoreWebProject.Repository
{
    public static class ModelBuilderExtension
    {
        public static void SetSeedData(this ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Student>().HasData(
        new Student { Id = 1, Department = "CSE", FirstName = "AKIB", StudentId = "C151006" },
        new Student { Id = 2, Department = "EEE", FirstName = "AKIB2", StudentId = "C151016" }
    );
        }
    }
}
