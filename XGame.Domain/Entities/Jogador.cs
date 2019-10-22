using System;
using XGame.Domain.Enum;
using XGame.Domain.Value_Objects;

namespace XGame.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }

        public SituacaoJogador Status { get; set; }
    }
}
