using Doador.Domain.commands;
using Doador.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.service.service
{
    public class DoadorService : IDoadorService
    {

        private readonly IDoadorRepository _doadorrepository;

        public DoadorService (IDoadorRepository doadorrepository)
        {
            _doadorrepository = doadorrepository;
        }

     

        public Task<string> postAsync(DoadorCommand command)
        {
            throw new NotImplementedException();

        }

        public void postAsync()
        {
            throw new NotImplementedException();
        }
    }
}
