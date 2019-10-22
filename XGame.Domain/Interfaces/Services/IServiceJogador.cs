using System.Collections.Generic;
using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

        AlterarJogadorRersponse AlterarJogador(AlterarJogadorRequest request);

        IEnumerable<JogadorResponse> ListarJogadores();
    }
}
