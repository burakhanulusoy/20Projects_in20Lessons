using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFremawork_CodeFirstMovie.DAL.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryNAME { get; set; }

        public List<Movies> Movies { get; set; }

    }
}
