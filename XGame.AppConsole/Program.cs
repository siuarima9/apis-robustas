using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do serviço");

            var requestAdd = new AdicionarJogadorRequest() { 
                PrimeiroNome = "Siuari",
                Sobrenome = "Damaceno",
                Email = "siuari@email.com",
                Senha = "123456"
            };

            //var request = new AutenticarJogadorRequest();

            Console.WriteLine("Cries instancia de um objeto reques");

            var resoibse = service.AdicionarJogador(requestAdd);

            //var response = service.AutenticarJogador(request);
            Console.ReadKey();
        }
    }
}
