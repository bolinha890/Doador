using Doador.Domain.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Interface
{
    public interface IProdutoRepository
    {
        Task<string> postAsync(ProdutoCommand command);

        void postAsync();
    }
}
