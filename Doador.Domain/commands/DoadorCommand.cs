using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.commands
{
    public  class DoadorCommand
    {
       public int DoadorId {  get; set; }
        public string DoadorNome { get; set; }
        public string DoadorCidade { get; set; }
        public string DoadorCep { get; set;}
        public string DoadorE_mail { get; set;}

        public string  Doadortelefone { get; set; }
    }
}
