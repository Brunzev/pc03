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
    }
}