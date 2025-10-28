using Microsoft.EntityFrameworkCore;

namespace revisao.c_.prova
{
    public class Program
    {
        //ja tera a string de conexao pronta
        static string _connectionString = "Server=localhost;" +
                                "Port=3306;" +
                                "Database=umfg_teste;" +
                                "Uid=root;" +
                                "Pwd=POSTREGRES_e_BETTER";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<Contexto.ContextoBancoDados>(options =>{options.UseMySQL(_connectionString);});
            var app = builder.Build();

            app.Run();
        }
    }
}
