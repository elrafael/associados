using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Core
{
    public interface IQuotaRepository
    {
        void Add(Quota a);
        void Edit(Quota a);
        void Remove(int Id);
        IEnumerable<Quota> List();
        Quota findById(int Id);
    }
}
