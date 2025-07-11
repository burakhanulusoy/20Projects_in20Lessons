using Project4_EntityFremawork_CodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFremawork_CodeFirstMovie.DAL.Context
{
    public class MovieContext:DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
