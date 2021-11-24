using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Truta_Diana_Lab8.Models;

namespace Truta_Diana_Lab8.Data
{
    public class Truta_Diana_Lab8Context : DbContext
    {
        public Truta_Diana_Lab8Context (DbContextOptions<Truta_Diana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Truta_Diana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Truta_Diana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Truta_Diana_Lab8.Models.Category> Category { get; set; }
    }
}
