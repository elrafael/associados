using Associados.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=gestorAssociadosConnectionString") { }
        public DbSet<Associado> Associados { get; set; }
        public DbSet<Quota> Quotas { get; set; }
        public DbSet<Morada> Morada { get; set; }
        public DbSet<User> User { get; set; }
    }
}
