using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_web_sql.Models
{
    public class Job
    {
        public int JobId { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public string Title { get; set; }   

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var e = modelBuilder.Entity<Job>();

            e.ToTable("jobs");

            e.HasKey(x => x.JobId);

            e.Property(x => x.JobId)
                .ValueGeneratedOnAdd();

            e.Property(x => x.Title)
                .HasMaxLength(30);

        }
    }
}
