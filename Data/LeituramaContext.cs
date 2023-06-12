using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Leiturama.Models;

    public class LeituramaContext : DbContext
    {
        public LeituramaContext (DbContextOptions<LeituramaContext> options)
            : base(options)
        {
        }

        public DbSet<Leiturama.Models.Artigo> Artigo { get; set; }

        public DbSet<Leiturama.Models.Venda> Venda { get; set; }

        public DbSet<Leiturama.Models.Categoria> Categoria { get; set; }
    }
