using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;
using XGame.Domain.Value_Objects;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;


        public ServiceJogador() { }
        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var email = new Email(request.Email);
            var nome = new Nome(request.PrimeiroNome, request.Sobrenome);

            var jogador = new Jogador(nome, email, request.Senha);

            if (this.IsInvalid()) return null;

            jogador = _repositoryJogador.AdicionarJogador(jogador);

            return (AdicionarJogadorResponse)jogador;
        }

        public AlterarJogadorRersponse AlterarJogador(AlterarJogadorRequest request)
        {
            if (request == null)
                AddNotification("AlterarJogador", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("AlterarJogador"));

            var jogador = _repositoryJogador.ObterJogadorPorId(request.Id);

            if (jogador == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            var nome = new Nome(request.PrimeiroNome, request.Sobrenome);
            var email = new Email(request.Email);

            jogador.AlterarJogador(nome, email, jogador.Status);

            AddNotifications(jogador);


            if (jogador.IsInvalid())
            {
                return null;
            }

            jogador = _repositoryJogador.AlterarJogador(jogador);

            return (AlterarJogadorRersponse)jogador;
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest"));
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email);

            jogador = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);

            return (AutenticarJogadorResponse)jogador;
        }

        public IEnumerable<JogadorResponse> ListarJogadores()
        {
            return _repositoryJogador.ListarJogadores().ToList().Select(x => (JogadorResponse)x).ToList();
        }
    }
}
