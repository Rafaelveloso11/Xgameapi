using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xgames.domain.Entities;

namespace XGame.Domain.Entities
{
    public class JogoPlataforma
    {
        public Guid Id { get; set; }
        public Jogos jogo { get; set; }
        public Plataforma Plataforma { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
