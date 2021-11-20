using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Template.Models
{
    public class Details
    {
        [Key]

        public int CId { get; set; }

        public String City { get; set; }

        public String Description { get; set; }

        public String TopPlacesToVisit { get; set; }

        public String Restaurants { get; set; }

        public String Hotels { get; set; }

        public String Guide { get; set; }





    }
}