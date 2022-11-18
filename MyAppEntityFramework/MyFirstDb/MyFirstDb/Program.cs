
using System;
using System.Data.SqlClient;

namespace sqltest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.;Database=BancoTeste;Trusted_Connection=True;";
            try
            {

                if (args.Length > 0)
                {

                    if( args[0] == "adicionar")
                    {
                        string name = args[1];
                        string telefone = args[2];
                        Random rnd = new Random();
                        int idDaLista = rnd.Next(1, 30000);

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            Console.WriteLine("\nQuery data example:");
                            Console.WriteLine("=========================================\n");

                            connection.Open();

                            String query = $@"INSERT INTO [dbo].[Lista]
                                           ([ID]
                                           ,[Nome]
                                           ,[Telefone])
                                     VALUES  ({idDaLista},'{name}','{telefone}')";

                            SqlCommand command = new SqlCommand(query, connection);

                            command.ExecuteNonQuery();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Comando nao reconhecido");

                    }             

                    return;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        Console.WriteLine("\nQuery data example:");
                        Console.WriteLine("=========================================\n");

                        connection.Open();

                        String sql = "SELECT NOME, TELEFONE FROM Lista";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"Nome: {reader.GetString(0)} Telefone: {reader.GetString(1)}");
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
        }

    }
}