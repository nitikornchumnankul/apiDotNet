using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
namespace api.Data
{
    public class CoopMISConText : DbContext
    {
        public CoopMISConText(DbContextOptions<CoopMISConText> options) : base(options) { } 
        
        public DbSet<File> file { get; set; }

        public DbSet<ResponsibleName> responsibleName { get; set; }
     
     }
}
