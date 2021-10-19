using System;
using Microsoft.EntityFrameworkCore;

namespace pc03.Data
{
    public class ApplicactionDbContext: DbContext
    {
        public ApplicactionDbContext(DbContextOptions<ApplicactionDbContext> options)
        : base (options)
        {         
        }
        public DbSet<pc03.Models.Solicitud> DataContactos{get; set;}
        public DbSet<pc03.Models.Categoria> DataCategoria{get; set;}
    }
}