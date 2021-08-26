using FirstDotNetCoreWebProject.Model;
using FirstDotNetCoreWebProject.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotNetCoreWebProject.SQLRepository.DAL
{
    public class SqlDbContext:DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SetSeedData();
        }
        public DbSet<Student> Students { get; set; }
    }
}
