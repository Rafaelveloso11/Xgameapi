﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest
    {
        public Nome Nome { get; set; }

        public string Senha { get; set; }
        public Email Email { get; set; }

     
    }
}
