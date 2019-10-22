using System;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AlterarJogadorRersponse : IResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public static explicit operator AlterarJogadorRersponse(Entities.Jogador v)
        {
            return new AlterarJogadorRersponse()
            {
                Id = v.Id,
                Email = v.Email.Endereco,
                PrimeiroNome = v.Nome.PrimeiroNome,
                Sobrenome = v.Nome.Sobrenome
            };
        }
    }
}
