using Doador.Domain.commands;

namespace Doador.Domain.Interface
{
    public interface IProdutoRepository
    {
        Task<string> postAsync(ProdutoCommand command);

        
    }
}
