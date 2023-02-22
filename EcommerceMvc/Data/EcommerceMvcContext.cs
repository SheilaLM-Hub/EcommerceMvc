using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EcommerceMvc.Models;

namespace EcommerceMvc.Data
{
    public class EcommerceMvcContext : DbContext
    {
        public EcommerceMvcContext (DbContextOptions<EcommerceMvcContext> options)
            : base(options)
        {
        }

        public DbSet<EcommerceMvc.Models.Categoria> Categoria { get; set; }
    }
}
