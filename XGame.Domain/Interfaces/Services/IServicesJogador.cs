using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicesJogador
    {
        AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);


    }
}
