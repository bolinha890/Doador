using Doador.Domain.commands;

namespace Doador.Domain.Interface
{

    public interface IDoadorService    
    {

        Task<string> postAsync(DoadorCommand command);

    }

}