using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Models;
using Microsoft.EntityFrameworkCore;

namespace Template.Models
{
    public class ApplicationDbConext : DbContext
    {
        public ApplicationDbConext(DbContextOptions<ApplicationDbConext> options) : base(options)
        {

        }
        public DbSet<Details> Details_Table { get; set; }
    }
}