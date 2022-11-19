
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using MyApp.Database;

namespace MyApp
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                using (var context = new ListaDbContext())
                {

                    List<Lista> listaDeClientes = context.Lista.ToList();

                    foreach (var cliente in listaDeClientes)
                    {
                       
                        Console.WriteLine($"Nome: {cliente.Nome} Telefone: {cliente.Telefone}");

                       
                    }

                    var teste = new Lista();

                    teste.Nome = "Griino";
                    teste.Telefone = "123456";

                    context.Lista.Add(teste);

                    context.SaveChanges();


                    //using (DbCommand command = context.Database.GetDbConnection().CreateCommand())
                    //{                       
                    //    String sql = "SELECT Id, Nome, TELEFONE FROM Lista";
                    //    command.CommandText = sql;
                    //    using (DbDataReader reader = command.ExecuteReader())
                    //    {
                    //        while (reader.Read())
                    //        {
                    //            int id = reader.GetInt32(0);
                    //            string name = reader.GetString(1);
                    //            string telefone = reader.GetString(2);
                    //            Cliente cliente = new Cliente();
                    //            cliente.Id = id;
                    //            cliente.Nome = name;
                    //            cliente.Telefone = telefone;

                    //            Console.WriteLine($"Nome: {cliente.Nome} Telefone: {cliente.Telefone}");
                    //        }

                    //    }
                    //}
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();

        }
    }
}