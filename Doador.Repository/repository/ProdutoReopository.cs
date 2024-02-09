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
    public class ProdutoReopository : IProdutoRepository
    {
         string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=true";


        public async Task<string> postAsync(ProdutoCommand command)
        {
            string queryInsert = @"INSERT INTO Produto(ProdutoNome, ProdutoDescricao, ProdutoCategoria, ProdutoDisponibilidade)
                                  VALUES(@ProdutoNome, @ProdutoDescricao, @ProdutoCategoria, @ProdutoDisponibilidade)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    ProdutoNome = command.ProdutoNome,
                    ProdutoDescricao = command.ProdutoDescricao,
                    ProdutoCategoria = command.ProdutoCategoria,
                    ProdutoDisponibilidade = command.ProdutoDisponibilidade,
                    
                });
            }
            return "Cadastro feito com sucesso";
        }

    
    }
}
