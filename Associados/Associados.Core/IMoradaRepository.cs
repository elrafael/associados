using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Core
{
    public interface IMoradaRepository
    {
        void Add(Morada m);
        void Edit(Morada m);
        void Remove(int Id);
        IEnumerable<Morada> List();
        IEnumerable<Morada> ListByTipoVia(string TipoVia);
        Morada findById(int Id);
    }
}
