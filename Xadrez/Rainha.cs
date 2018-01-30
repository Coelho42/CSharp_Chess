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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                     Construtor                                                     *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Construtor default do Rainha
        /// </summary>
        public Rainha()
        {
        }

        /// <summary>
        /// Construtor para criar um Rainha
        /// </summary>
        /// <param name="pieceName">nome da peça</param>
        /// <param name="colourBlack">cor da peça</param>
        public Rainha(string pieceName, bool colourBlack)
        {
            this.pieceName = pieceName;
            this.colourBlack = colourBlack;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                      Métodos                                                       *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Método mover da Rainha
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Se pode mover ou não </returns>
        public override bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Mover para os Lados

            bool canMove = false;

            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    #region Up

                    if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                    {
                        return true;
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 280 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 350 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 420 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 490 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    #endregion

                    #region Down

                    if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                    {
                        return true;
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 280 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 350 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 420 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 490 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    #endregion

                    #region Right

                    if (pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        return true;
                    }

                    else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 350, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 350, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 420, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    #endregion

                    #region Left

                    if (pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        return true;
                    }

                    else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 350, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 350, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 420, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
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

            #endregion

            #region Mover nas Diagonais


            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
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
     
        /// <summary>
        /// Método mover da Rainha
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Se pode mover ou não </returns>
        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Mover para os Lados

            bool canMove = false;

            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    #region Up

                    if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                    {
                        return true;
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 280 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 350 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 420 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 490 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y - 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    #endregion

                    #region Down

                    if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                    {
                        return true;
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 210 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 280 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 350 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 420 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 490 == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 140) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 210) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 280) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 350) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 420) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    #endregion

                    #region Right

                    if (pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        return true;
                    }

                    else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 350, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X + 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 350, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X + 420, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    #endregion

                    #region Left

                    if (pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        return true;
                    }

                    else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 210 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 280 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 350 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 420 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 350, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else
                        {
                            canMove = true;
                        }
                    }

                    else if (pecaOrigemLocalizacao.X - 490 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y)
                    {
                        if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 70, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 140, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 210, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 280, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 350, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
                        {
                            canMove = false;
                        }

                        else if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X - 420, pecaOrigemLocalizacao.Y) && tabuleiro[i, j].getcolourBlack() != null)
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

            #endregion

            #region Mover nas Diagonais


            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
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
