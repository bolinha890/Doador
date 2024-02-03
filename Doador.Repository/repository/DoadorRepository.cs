using Dapper;
using Doador.Domain.commands;
using Doador.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Repository.repository
{
    public class DoadorRepository : IDoadorRepository
    {
       
        
            private string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=true";

            public Task<IEnumerable<DoadorCommand>> GetDoadoresAsync()
            {
                throw new NotImplementedException();
            }

            public async Task<string> PostAsync(DoadorCommand command)
            {
                string queryInsert = @"INSERT INTO Doador(Nome, Cidade, CEP, Email, Telefone)
                                  VALUES(@Nome, @Cidade,  @CEP, @Email, @Telefone)";
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    conn.Execute(queryInsert, new
                    {
                        Nome = command.DoadorNome,
                        Cidade = command.DoadorCidade,
                        CEP = command.DoadorCep,
                        Email = command.DoadorE_mail,
                        Telefone = command.Doadortelefone
                    });
                }
                return queryInsert;
                {
                    throw new NotImplementedException();
                }
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
