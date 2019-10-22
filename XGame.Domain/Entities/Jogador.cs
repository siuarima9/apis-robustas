using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGame.Domain.Enum;
using XGame.Domain.Extensions;
using XGame.Domain.Resources;
using XGame.Domain.Value_Objects;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Senha", "6", "32"));

            if (IsValid())
                Senha = Senha.ConvertToMD5();

            AddNotifications(email);
        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Senha", "6", "32"));

            if (IsValid())
                Senha = Senha.ConvertToMD5();

            AddNotifications(nome, email);
        }

        public void AlterarJogador(Nome nome, Email email, SituacaoJogador status)
        {
            Nome = nome;
            Email = email;

            new AddNotifications<Jogador>(this).IfFalse(status == SituacaoJogador.Ativo, "Não é possivel alterar jogador, pois status não permite");

            AddNotifications(nome, email);
        }

        public Guid Id { get; private set; }

        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }

        public SituacaoJogador Status { get; private set; }
    }
}
