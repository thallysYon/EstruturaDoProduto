using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EstruturaDoProduto.Models;

namespace EstruturaDoProduto.Data
{
    public class EstruturaDoProdutoContext : DbContext
    {
        public EstruturaDoProdutoContext (DbContextOptions<EstruturaDoProdutoContext> options)
            : base(options)
        {
        }

        public DbSet<EstruturaDoProduto.Models.Produto> Produto { get; set; } = default!;
    }
}
