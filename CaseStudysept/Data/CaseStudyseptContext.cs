using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaseStudysept.Models;

namespace CaseStudysept.Data
{
    public class CaseStudyseptContext : DbContext
    {
        public CaseStudyseptContext (DbContextOptions<CaseStudyseptContext> options)
            : base(options)
        {
        }

        public DbSet<CaseStudysept.Models.Tasks> Tasks { get; set; } = default!;

        public DbSet<CaseStudysept.Models.Employee> Employee { get; set; }
    }
}
