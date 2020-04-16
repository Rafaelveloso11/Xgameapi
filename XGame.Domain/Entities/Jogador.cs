using System;

namespace Xgames.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Senha { get; set; }

        public string Email { get; set; }
    }
}
