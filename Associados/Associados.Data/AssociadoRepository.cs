using Associados.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Data
{
    public class AssociadoRepository : IAssociadoRepository
    {

        AssociadoContext context = new AssociadoContext();
        public void Add(Associado a)
        {
            context.Associados.Add(a);
            context.SaveChanges();
        }

        public void Edit(Associado a)
        {
            context.Entry(a).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int Id)
        {
            Associado a = context.Associados.Find(Id);
            context.Associados.Remove(a);
            context.SaveChanges();
        }

        public IEnumerable<Associado> List()
        {
            return context.Associados;
        }

        public Associado findById(int Id)
        {
            var result = (from r in context.Associados where r.Id == Id select r).FirstOrDefault();

            return result;
        }
    }
}
