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
            bool canMove = false;
            int c = 1;

            // inferior direito
            if (pecaOrigemLocalizacao.Y + 70 * c == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * c == pecaDestinoLocalizacao.X)
            {
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 350, pecaOrigemLocalizacao.Y + 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 420, pecaOrigemLocalizacao.Y + 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }

                        if (canMove == false)
                        {
                            break;
                        }
                        c++;
                    }
                }
                return canMove;
            }

            // lado inferior esquerdo
            else if (pecaOrigemLocalizacao.Y + 70 * c == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * c == pecaDestinoLocalizacao.X)
            {
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 350, pecaOrigemLocalizacao.Y + 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 420, pecaOrigemLocalizacao.Y + 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }

                        if (canMove == false)
                        {
                            break;
                        }
                        c++;
                    }
                }
                return canMove;
            }

            // lado superior direito
            else if (pecaOrigemLocalizacao.Y - 70 * c == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * c == pecaDestinoLocalizacao.X)
            {
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 350, pecaOrigemLocalizacao.Y - 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 420, pecaOrigemLocalizacao.Y - 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }

                        if (canMove == false)
                        {
                            break;
                        }
                        c++;
                    }
                }
                return canMove;
            }

            // lado superior direita
            else if (pecaOrigemLocalizacao.Y - 70 * c == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * c == pecaDestinoLocalizacao.X)
            {
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 350, pecaOrigemLocalizacao.Y - 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 420, pecaOrigemLocalizacao.Y - 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }

                        if (canMove == false)
                        {
                            break;
                        }
                        c++;
                    }
                }
                return canMove;
            }
            return canMove;
        }

        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            bool canMove = true;
            int c = 1;

            // inferior direito
            if (pecaOrigemLocalizacao.Y + 70 * c == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * c == pecaDestinoLocalizacao.X)
            {
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 350, pecaOrigemLocalizacao.Y + 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 420, pecaOrigemLocalizacao.Y + 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }

                        if (canMove == false)
                        {
                            break;
                        }
                        c++;
                    }
                }
                return canMove;
            }

            // lado inferior esquerdo
            else if (pecaOrigemLocalizacao.Y + 70 * c == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * c == pecaDestinoLocalizacao.X)
            {
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 350, pecaOrigemLocalizacao.Y + 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 420, pecaOrigemLocalizacao.Y + 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }

                        if (canMove == false)
                        {
                            break;
                        }
                        c++;
                    }
                }
                return canMove;
            }

            // lado superior direito
            else if (pecaOrigemLocalizacao.Y - 70 * c == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 * c == pecaDestinoLocalizacao.X)
            {
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 350, pecaOrigemLocalizacao.Y - 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 420, pecaOrigemLocalizacao.Y - 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }

                        if (canMove == false)
                        {
                            break;
                        }
                        c++;
                    }
                }
                return canMove;
            }

            // lado superior direita
            else if (pecaOrigemLocalizacao.Y - 70 * c == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 * c == pecaDestinoLocalizacao.X)
            {
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 350, pecaOrigemLocalizacao.Y - 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 420, pecaOrigemLocalizacao.Y - 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }

                        if (canMove == false)
                        {
                            break;
                        }
                        c++;
                    }
                }
                return canMove;
            }
            return canMove;
        }
    }
}