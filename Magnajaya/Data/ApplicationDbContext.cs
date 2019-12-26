using System;
using System.Collections.Generic;
using System.Text;
using Magnajaya.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Magnajaya.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CbBank> Banks { get; set; }
        public DbSet<CbSrccd> CbCodes { get; set; }
        public DbSet<CbGrp> CbGroups { get; set; }
        public DbSet<CbTransH> CbTransHs { get; set; }
        public DbSet<CbTransD> CbTransDs { get; set; }
    }
}
