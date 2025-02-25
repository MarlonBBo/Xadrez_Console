﻿
using tabuleiro;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimento { get;protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca( Cor cor, Tabuleiro tab)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tab = tab;
            this.QuantidadeMovimento = 0;
        }
    }
}
