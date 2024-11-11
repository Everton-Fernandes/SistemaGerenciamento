using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoClientesProdutos.Data
{
    public class DatabaseConfig
    {
        // Connection string estática
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=DBAEverton;Database=SistemaGerenciamento";

        // Método estático para obter a conexão
        public static NpgsqlConnection GetConnection()
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                // Em caso de erro, você pode logar a exceção ou tratá-la conforme necessário
                Console.WriteLine("Erro ao criar conexão com o banco de dados: " + ex.Message);
                throw;
            }
        }
    }
}
