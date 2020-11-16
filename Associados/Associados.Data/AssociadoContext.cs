using Associados.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Data
{
    public class AssociadoContext: DbContext
    {
        public AssociadoContext() : base("name=gestorAssociadosConnectionString")
        {

        }

        public DbSet<Associado> Associados { get; set; }
    }
}
