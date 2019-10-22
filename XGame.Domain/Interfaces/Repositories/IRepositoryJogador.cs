using System;
using System.Collections.Generic;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);

        Jogador AdicionarJogador(Jogador request);

        IEnumerable<Jogador> ListarJogadores();

        Jogador ObterJogadorPorId(Guid id);

        Jogador AlterarJogador(Jogador jogador);
    }
}
