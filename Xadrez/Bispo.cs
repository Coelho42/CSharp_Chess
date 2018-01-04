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

            bool breakMove = false;

            /*
            if (pecaOrigemLocalizacao.Y - 70  == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * c == pecaDestinoLocalizacao.X)
            {
                // Move-se para a diagonal superior esquerda
                for (int i = pecaOrigemLocalizacao.Y; i >= pecaDestinoLocalizacao.Y; i = i - 70)
                {
                    for (int j = pecaOrigemLocalizacao.X; j >= pecaDestinoLocalizacao.X; j = j + 70)
                    {
                        if (tabuleiro[i, pecaDestinoLocalizacao.X].getcolourBlack() == null && tabuleiro[j, pecaDestinoLocalizacao.Y].getcolourBlack() == null)
                        {
                            return true;
                        }
                        else
                        {
                            breakMove = true;
                        }

                        if (breakMove == true)
                        {
                            break;
                        }
                    }
                }
            }

            if (pecaOrigemLocalizacao.Y - 70  == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * c == pecaDestinoLocalizacao.X)
            {
                // Move-se para a diagonal superior direita
                for (int i = pecaOrigemLocalizacao.Y; i >= pecaDestinoLocalizacao.Y; i = i - 70)
                {
                    for (int j = pecaOrigemLocalizacao.X; j >= pecaDestinoLocalizacao.X; j = j + 70)
                    {
                        if (tabuleiro[i, pecaDestinoLocalizacao.X].getcolourBlack() == null && tabuleiro[j, pecaDestinoLocalizacao.Y].getcolourBlack() == null)
                        {
                            return true;
                        }
                        else
                        {
                            breakMove = true;
                        }
                    }
                }                        
            }

    */
            if (pecaOrigemLocalizacao.Y + 140  == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X)
            {
                // Move-se para a diagonal superior esquerda
                for (int i = pecaOrigemLocalizacao.Y; i >= pecaDestinoLocalizacao.Y; i = i + 70)
                {
                    for (int j = pecaOrigemLocalizacao.X; j >= pecaDestinoLocalizacao.X; j = j - 70)
                    {
                        if (tabuleiro[i, pecaDestinoLocalizacao.X].getcolourBlack() == null && tabuleiro[j, pecaDestinoLocalizacao.Y].getcolourBlack() == null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }                   
                }
                return false;
            }
            else
            {
                return false;
            }

            /*
            else if (pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * c == pecaDestinoLocalizacao.X)
            {
                // Move-se para a diagonal inferior direita
                for (int i = pecaOrigemLocalizacao.Y; i >= pecaDestinoLocalizacao.Y; i = i - 70)
                {
                    for (int j = pecaOrigemLocalizacao.X; j >= pecaDestinoLocalizacao.X; j = j + 70)
                    {
                        if (tabuleiro[i, pecaDestinoLocalizacao.X].getcolourBlack() == null && tabuleiro[j, pecaDestinoLocalizacao.Y].getcolourBlack() == null)
                        {
                            breakMove = true;
                        }
                    }
                }                  
            }

            else
            {
                return false;
            }   
            */
        }                 
    }
}

