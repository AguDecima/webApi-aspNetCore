using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_web_sql.Models
{
    public class Company
    {

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public List<Job> Jobs { get; set; }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var e = modelBuilder.Entity<Company>();

            e.ToTable("companias");

            e.HasKey(x => x.CompanyId);

            e.Property(x => x.CompanyId)
                .ValueGeneratedOnAdd();

            e.Property(x => x.Name)
                .HasMaxLength(30);
        }
    }
}
