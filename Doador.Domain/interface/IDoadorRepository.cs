using Doador.Domain.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Interface
{
    public interface IDoadorRepository
    {
        Task<string> postAsync(DoadorCommand command);

        void postAsync();
    }
}
