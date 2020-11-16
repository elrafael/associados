using Associados.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Data
{
    public class AssociadoDbInit : DropCreateDatabaseIfModelChanges<AssociadoContext>
    {
        protected override void Seed(AssociadoContext context)
        {
            context.Associados.Add(new Associado
            {
                Id = 1,
                Nome = "Rafael",
                Apelido = "V. de Oliveira",
                Email = "elrafael123@gmail.com"
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
