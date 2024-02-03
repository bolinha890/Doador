using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.commands
{
    public class ProdutoCommand
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string ProdutoDescricao { get; set; }
        public long ProdutCategoria { get; set; }
        public string ProdutoDisponibilidade{ get; set; }

        public int Doadortelefone { get; set; }
    }
}
