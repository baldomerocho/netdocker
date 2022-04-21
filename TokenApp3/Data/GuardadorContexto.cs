using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokenApp3.Models;

namespace TokenApp3.Data
{
    public class GuardadorContexto : DbContext
    {
        public GuardadorContexto(DbContextOptions<GuardadorContexto> options) : base(options)
        {

        }

        // crear nuestro dbset
        public DbSet<Guardador> GuardadoItems { get; set; }
    }
}
