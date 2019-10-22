using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Infra.Persistence
{
    public class XGameContext : DbContext
    {
        public XGameContext() : base("XGameConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        //public IDbSet<Jogador> Jogadores{ get; set; }

    }
}
