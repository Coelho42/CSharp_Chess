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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                     Construtor                                                     *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Construtor default do Cavalo
        /// </summary>
        public Cavalo()
        {
        }

        /// <summary>
        /// Construtor para criar um CAvalo
        /// </summary>
        /// <param name="pieceName">nome da peça</param>
        /// <param name="colourBlack">cor da peça</param>
        public Cavalo(string pieceName, bool colourBlack)
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
        /// Método mover do Cavalo
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Se pode mover ou não </returns>
        public override bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Mover em L

            // Movimenta a peça para 2 casas para cima e 1 para a esquerda
            if (pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para cima e 1 para a direita
            else if (pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a esquerda e mais uma 1 para a esquerda
            else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a esquerda e mais uma 1 para a direita
            else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a direita e mais uma 1 para a esquerda
            else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a direita e mais uma 1 para a direita
            else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para baixo e 1 para a esquerda
            else if (pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para baixo e 1 para a direita
            else if (pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            else
            {
                return false;
            }

            #endregion
        }

        /// <summary>
        /// Método mover do Cavalo
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Se pode mover ou não </returns>
        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Mover em L

            // Movimenta a peça para 2 casas para cima e 1 para a esquerda
            if (pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para cima e 1 para a direita
            else if (pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a esquerda e mais uma 1 para a esquerda
            else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a esquerda e mais uma 1 para a direita
            else if (pecaOrigemLocalizacao.X - 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a direita e mais uma 1 para a esquerda
            else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para a direita e mais uma 1 para a direita
            else if (pecaOrigemLocalizacao.X + 140 == pecaDestinoLocalizacao.X && pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para baixo e 1 para a esquerda
            else if (pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            // Movimenta a peça para 2 casas para baixo e 1 para a direita
            else if (pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }

            else
            {
                return false;
            }

            #endregion
        }
    }
}


    

