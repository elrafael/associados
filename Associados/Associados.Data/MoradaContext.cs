using Associados.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Data
{
    public class MoradaContext : DbContext
    {
        public MoradaContext() : base("name=gestorAssociadosConnectionString") { }

        public DbSet<Morada> Morada { get; set; }
    }
}
