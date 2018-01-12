﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Peao : Peca
    {

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                      Métodos                                                       *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Método mover do Peão
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Se pode mover ou não </returns>
        public override bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Mover uma ou duas casas para a frente

            bool canMove = false;                                       // O canMove toma o valor de false 

            // Ciclo for para as colunas do tabuleiro
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                // Ciclo for para as linhas do tabuleiro
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    // Checka se é a fez do player 1 de jogar
                    if (player1Turn == true)
                    {
                        // Se for a primeira jogada dos peões pretos o peão pode mover duas em casas em fez de uma só
                        if (pecaOrigemLocalizacao.Y == 70)
                        {
                            // Checka se o utilizador mexeu-se uma casa para a frente
                            if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                            {
                                canMove = true;
                            }
                            // Checka se o utilizador mexeu-se duas casa para a frente
                            else if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y)
                            {
                                // Checka se entre a localização de origem da peça e a do destino existe uma peça, se não existir a peça pode-se mover caso contrário da return false
                                if (tabuleiro[i, j].Location == new Point(pecaOrigemLocalizacao.X, pecaOrigemLocalizacao.Y + 70) && tabuleiro[i, j].getcolourBlack() != null)
                                {
                                    canMove = false;
                                }

                                else
                                {
                                    canMove = true;
                                }
                            }
                        }
                        else
                        {
                            if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                            {
                                canMove = true;
                            }
                        }
                    }
                    else
                    {
                        if (pecaOrigemLocalizacao.Y == 420)
                        {
                            if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                            {
                                canMove = true;
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
                        }
                        else
                        {
                            if (pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                            {
                                canMove = true;
                            }
                        }
                    }

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
        /// Método mover do Peão
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Se pode mover ou não </returns>
        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Comer uma casa nas diagonais

            if (player1Turn == true)
            {
                // Come a peça que estiver na diagonal esquerda dos peões pretos
                if (pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                {
                    return true;
                }

                // Come a peça que estiver na diagonal direita dos peões pretos
                else if (pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                // Come a peça que estiver na diagonal esquerda dos peões brancos
                if (pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                {
                    return true;
                }

                // Come a peça que estiver na diagonal esquerda dos peões brancos
                else if (pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            #endregion
        }
    }
}
    

                
                    
                           
                







         
               
   