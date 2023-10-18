using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using arielramos_tabla2.Models;

namespace arielramos_tabla2.Data
{
    public class arielramos_tabla2Context : DbContext
    {
        public arielramos_tabla2Context (DbContextOptions<arielramos_tabla2Context> options)
            : base(options)
        {
        }

        public DbSet<arielramos_tabla2.Models.Burger> Burger { get; set; } = default!;
        public DbSet<arielramos_tabla2.Models.Promo> Promo { get; set; }
    }
}
