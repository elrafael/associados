using Associados.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Data
{
    public class QuotaRepository : IQuotaRepository
    {
        Context context = new Context();
        public void Add(Quota m)
        {
            context.Quotas.Add(m);
            context.SaveChanges();
        }

        public void Edit(Quota m)
        {
            context.Entry(m).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int Id)
        {
            Quota a = context.Quotas.Find(Id);
            context.Quotas.Remove(a);
            context.SaveChanges();
        }

        public IEnumerable<Quota> List()
        {
            return context.Quotas;
        }

        public Quota findById(int Id)
        {
            var result = (from r in context.Quotas where r.Id == Id select r).FirstOrDefault();

            return result;
        }
    }
}
