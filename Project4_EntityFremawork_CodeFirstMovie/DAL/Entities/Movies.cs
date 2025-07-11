using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFremawork_CodeFirstMovie.DAL.Entities
{
    public class Movies
    {
        public int MoviesID { get; set; }
        public string MovieNAME { get; set; }
        public int Duration { get; set; }
        public string Description  { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } // Navigation property to Category
    }
}
