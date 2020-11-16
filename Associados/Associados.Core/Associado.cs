using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Core
{
    public class Associado
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }

    }
}
