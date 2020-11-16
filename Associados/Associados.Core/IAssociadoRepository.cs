using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Core
{
    public interface IAssociadoRepository
    {
        void Add(Associado a);
        void Edit(Associado a);
        void Remove(int Id);
        IEnumerable<Associado> List();
        Associado findById(int Id);
    }
}
