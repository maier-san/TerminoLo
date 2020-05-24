using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TerminoLo.Data
{
   public class TerminoLoDbContext : DbContext
   {
      public TerminoLoDbContext(DbContextOptions<TerminoLoDbContext> dbContextOptions)
         : base(dbContextOptions)
      {
         
      }

      public DbSet<Begriff> Begriffe { get; set; }
   }
}
