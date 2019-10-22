using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.Value_Objects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50, Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("PrimeiroNome", "3", "50"))
                .IfNullOrInvalidLength(x => x.Sobrenome, 3, 50, Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("SegundoNome", "3", "50"));
        }

        public string PrimeiroNome { get; private set; }

        public string Sobrenome { get; private set; }
    }
}
