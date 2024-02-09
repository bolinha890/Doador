using Doador.Domain.commands;

namespace Doador.Domain.Interface
{
    public interface IProdutoService
    {
        Task<string>postAsync(ProdutoCommand Command);

        
    }
}
