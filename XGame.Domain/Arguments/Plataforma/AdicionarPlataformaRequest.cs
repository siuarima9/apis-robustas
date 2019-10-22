using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Plataforma
{
    public class AdicionarPlataformaRequest : IRequest
    {
        public string Nome { get; set; }
    }
}
