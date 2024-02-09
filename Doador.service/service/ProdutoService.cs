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
      private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public Task<string> postAsync(ProdutoCommand Command)
        {
            return _repository.postAsync(Command);
        }

       
    }
}
