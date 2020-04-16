using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Entities;

namespace xgames.domain.Entities
{
    public class MeuJogo
    {
        public Guid Id { get; set; }
        public JogoPlataforma JogoPlataforma { get; set; }
        public DateTime Datadesejo { get; set; }
        public bool Desejo { get; set; }
        public bool Troco { get; set; }
        public bool Vendo { get; set; }
     
    }
}
