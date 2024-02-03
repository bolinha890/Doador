using Doador.Domain.commands;
using Doador.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.service.service
{
    public class ProdutoService : IProdutoService
    {
        public void GetAsync()
        {

        }

        public void postAsync() 
        { 

        }

        public Task<string> postAsync(ProdutoCommand Command)
        {
            throw new NotImplementedException();
        }
    }
}
