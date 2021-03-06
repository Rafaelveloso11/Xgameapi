﻿using System;
using XGame.Domain.Enum;
using XGame.Domain.ValueObjects;

namespace Xgames.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }
        public Nome Nome { get; set; }

        public string Senha { get; set; }
        public Email Email { get; set; }

        public EnumSituacaoJogador Status { get; set; }
    }
}
