using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Template.Models
{
    public class TourContext
    {
        public DbSet<Details> Details_Table { get; set; }
    }
    
}