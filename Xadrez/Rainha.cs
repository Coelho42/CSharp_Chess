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
            #region Mover na Diagonal

            bool canMove = false;

            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    #region Up

                    if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }

                    #endregion

                    #region Down

                    if (pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }

                    #endregion

                    #region Right

                    if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }

                    #endregion

                    #region Left

                    if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }

                    #endregion

                    #region Down Right

                    if (pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                    {
                        canMove = true;
                    }

                    else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 280 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 350 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 420 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 490 == pecaDestinoLocalizacao.Y)
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
                    }

                    #endregion

                    #region Down Left

                    if (pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                    {
                        canMove = true;
                    }

                    else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 280 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 350 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 420 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 490 == pecaDestinoLocalizacao.Y)
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
                    }

                    #endregion

                    #region Top Right

                    if (pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                    {
                        canMove = true;
                    }

                    else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 280 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 350 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 420 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 490 == pecaDestinoLocalizacao.Y)
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
                    }

                    #endregion

                    #region Top Left

                    if (pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                    {
                        canMove = true;
                    }

                    else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 280 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 350 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 420 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 490 == pecaDestinoLocalizacao.Y)
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
                    }

                    #endregion

                    if (canMove == false)
                    {
                        break;
                    }
                }

                if (canMove == false)
                {
                    break;
                }
            }

            if (canMove == false)
            {
                return false;
            }
            else
            {
                return true;
            }

            #endregion
        }

        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Mover na Diagonal

            bool canMove = false;

            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    #region Up

                    if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }

                    #endregion

                    #region Down

                    if (pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }

                    #endregion

                    #region Right

                    if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }

                    #endregion

                    #region Left

                    if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }

                    #endregion

                    #region Down Right

                    if (pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                    {
                        canMove = true;
                    }

                    else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 280 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 350 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 420 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 490 == pecaDestinoLocalizacao.Y)
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
                    }

                    #endregion

                    #region Down Left

                    if (pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                    {
                        canMove = true;
                    }

                    else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 280 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 350 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 420 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 490 == pecaDestinoLocalizacao.Y)
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
                    }

                    #endregion

                    #region Top Right

                    if (pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                    {
                        canMove = true;
                    }

                    else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 280 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 350 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 420 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 490 == pecaDestinoLocalizacao.Y)
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
                    }

                    #endregion

                    #region Top Left

                    if (pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                    {
                        canMove = true;
                    }

                    else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 280 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 350 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 420 == pecaDestinoLocalizacao.Y)
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

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 490 == pecaDestinoLocalizacao.Y)
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
                    }

                    #endregion

                    if (canMove == false)
                    {
                        break;
                    }
                }

                if (canMove == false)
                {
                    break;
                }
            }

            if (canMove == false)
            {
                return false;
            }
            else
            {
                return true;
            }

            #endregion
        }
    }
}
