using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Bispo : Peca
    {

        public override bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            for (int i = 1; i < 9; i++)
            {
                // lado inferior esquerdo
                if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
                {
                    if (tabuleiro[pecaDestinoLocalizacao.Y, pecaDestinoLocalizacao.X].getcolourBlack() == null)
                    {
                        return true;
                    }                 
                }

                // lado inferior direito
                else if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }

                // lado superior esquerdo
                else if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }

                // lado superior direita
                else if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            // lado inferior esquerdo
            if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
            {
                if (tabuleiro[pecaDestinoLocalizacao.Y, pecaDestinoLocalizacao.X].getcolourBlack() == null)
                {
                    return true;
                }
            }

            // lado inferior direito
            else if (pecaOrigemLocalizacao.Y + 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // lado superior esquerdo
            else if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // lado superior direita
            else if (pecaOrigemLocalizacao.Y - 70 * i == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * i == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            return false;
        }
    }
}
