using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirichenko_pr7
{
    public partial class Pet
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Species { get; set; }

        public int? Age { get; set; }

        public decimal? Weight { get; set; }

        public bool? IsAdopted { get; set; }
    }
}
