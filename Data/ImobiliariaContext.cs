using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Imobiliaria.Models;

namespace Imobiliaria.Data
{
    public class ImobiliariaContext : DbContext
    {
        public ImobiliariaContext (DbContextOptions<ImobiliariaContext> options)
            : base(options)
        {
        }

        public DbSet<Imobiliaria.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Imobiliaria.Models.Imovel> Imovel { get; set; } = default!;
    }
}
