using XGame.Domain.Arguments.Plataforma;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlaraforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);
    }
}
