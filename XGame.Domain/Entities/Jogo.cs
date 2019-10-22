using System;

namespace XGame.Domain.Entities
{
    public class Jogo
    {
        public Guid Id{ get; set; }

        public string Nome { get; set; }

        public string Resenha { get; set; }

        public string Produtora { get; set; }

        public string Distribuidora { get; set; }

        public string Genero { get; set; }

        public string SiteOficial { get; set; }
    }
}
