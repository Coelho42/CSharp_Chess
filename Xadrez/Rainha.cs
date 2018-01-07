using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Rainha : Peca
    {
        public override bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {

            for (int i = 1; i < 9; i++)
            {
                // Move-se para a cima
                if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
                // Move-se para baixo
                else if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
                // Move-se para a esquerda
                else if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
                // Move-se para a direita
                else if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
                // Move-se para a diagonal superior direita
                if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
                // Move-se para a diagonal superior esquerda
                else if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
                // Move-se para a diagonal inferior direita
                else if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
                // Move-se para a diagonal inferior esquerda
                else if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            // Move-se para a cima
            if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para baixo
            else if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a esquerda
            else if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a direita
            else if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal superior direita
            if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal superior esquerda
            else if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal inferior direita
            else if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal inferior esquerda
            else if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            return false;
        }
    }
}
