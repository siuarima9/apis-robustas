using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.Value_Objects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string PrimeiroNome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
