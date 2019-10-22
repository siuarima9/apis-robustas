using System;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.Resources;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Mensagem { get; set; }

        public static explicit operator AdicionarJogadorResponse(Entities.Jogador v)
        {
            return new AdicionarJogadorResponse() { 
                Id = v.Id,
                Mensagem = Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
