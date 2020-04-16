using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicesPlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);


    }
}
