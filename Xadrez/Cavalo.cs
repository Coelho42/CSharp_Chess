using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Cavalo : Peca
    {
        public override bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
      
            // Movimenta a peça para 2 casas para cima e 1 para a esquerda
            if (pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para cima e 1 para a direita
            if (pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a esquerda e mais uma 1 para a esquerda
            if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a esquerda e mais uma 1 para a direita
            if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a direita e mais uma 1 para a esquerda
            if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a direita e mais uma 1 para a direita
            if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para baixo e 1 para a esquerda
            if (pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para baixo e 1 para a direita
            if (pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
