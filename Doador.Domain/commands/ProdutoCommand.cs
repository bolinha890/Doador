using Doador.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.commands
{
    public class ProdutoCommand
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string ProdutoDescricao { get; set; }
        public ECategoriaProdutos ProdutoCategoria { get; set; }
        public bool ProdutoDisponibilidade{ get; set; }

       
        
        


    }
}
