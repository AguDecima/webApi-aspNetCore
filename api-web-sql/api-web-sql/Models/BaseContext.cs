using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_web_sql.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext()
        { }

        public BaseContext(DbContextOptions<BaseContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=localhost;userid=root;pwd=;port=3306;database=jobings_webapi;sslmode=none;");
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Company.OnModelCreating(modelBuilder);
            Job.OnModelCreating(modelBuilder);
        }
    }
}
