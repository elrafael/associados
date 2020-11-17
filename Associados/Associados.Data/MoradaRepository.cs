using Associados.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Data
{
    public class MoradaRepository : IMoradaRepository
    {
        Context context = new Context();
        public void Add(Morada m)
        {
            context.Morada.Add(m);
            context.SaveChanges();
        }

        public void Edit(Morada m)
        {
            context.Entry(m).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int Id)
        {
            Morada a = context.Morada.Find(Id);
            context.Morada.Remove(a);
            context.SaveChanges();
        }

        public IEnumerable<Morada> List()
        {
            return context.Morada;
        }

        public IEnumerable<Morada> ListByTipoVia(string TipoVia)
        {
            var result = (from r in context.Morada where r.TipoVia == TipoVia select r).ToList();

            return result;
        }

        public Morada findById(int Id)
        {
            var result = (from r in context.Morada where r.Id == Id select r).FirstOrDefault();

            return result;
        }
    }
}
