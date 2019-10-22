using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;


        public ServiceJogador() { }
        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var id = _repositoryJogador.AdicionarJogador(request);

            return new AdicionarJogadorResponse() { Id = id, Mensagem = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJogadorRequest é obrigatório");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe email");
            }

            if (IsEmail(request.Email))
            {
                throw new Exception("Informe email");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("informe a senha");
            }

            if(request.Senha.Length < 6)
            {
                throw new Exception("Senha deve ter 6 ou mais caracteres");
            }

            var response = _repositoryJogador.AutenticarJogador(request);

            return response
        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
