﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xgames.domain.Entities
{
    public class Jogo
    {
        public Guid id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Produtora { get; set; }
        public string Distribuidora { get; set; }
        public string Genero { get; set; }
    }
}