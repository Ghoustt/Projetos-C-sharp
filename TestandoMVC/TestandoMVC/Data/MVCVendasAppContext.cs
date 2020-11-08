using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCVendasApp.Models;

namespace MVCVendasApp.Data
{
    public class MVCVendasAppContext : DbContext
    {

        public MVCVendasAppContext(DbContextOptions<MVCVendasAppContext> options)
            : base(options)
        {
        }


        public DbSet<ClienteModel> ClienteModel { get; set; }

        public DbSet<ProdutoModel> ProdutoModel { get; set; }

        public DbSet<VendaModel> VendaModel { get; set; }

        public DbSet<VendaItensModel> VendaItensModel { get; set; }
    }

}
