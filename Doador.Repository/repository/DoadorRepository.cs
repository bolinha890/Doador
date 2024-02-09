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
       
        
             string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=true";


                        
            public async Task<string> postAsync(DoadorCommand command)
            {
                string queryInsert = @"INSERT INTO Doador(DoadorNome, DoadorCidade, DoadorCEP, DoadorE_mail, Doadortelefone)
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
            return "Cadastro feito coom sucesso";
            }

       
    
    }
}
