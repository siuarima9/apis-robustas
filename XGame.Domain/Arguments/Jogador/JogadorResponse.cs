using System;
using XGame.Domain.Entities;
using XGame.Domain.Enum;
using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.Value_Objects;

namespace XGame.Domain.Arguments.Jogador
{
    public class JogadorResponse : IResponse
    {
        public Guid Id { get; set; }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }

        public static explicit operator JogadorResponse(Entities.Jogador v)
        {
            return new JogadorResponse() { 
                Id = v.Id,
                Email = v.Email.Endereco,
                NomeCompleto = v.Nome.PrimeiroNome + " " + v.Nome.Sobrenome,
                Status = v.Status.ToString()
            };
        }
    }
}
