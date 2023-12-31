﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Rei : Peca
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                     Construtor                                                     *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Construtor para criar um Rei
        /// </summary>    
        public Rei()
        {         
        }

        /// <summary>
        /// Construtor para criar um Rei
        /// </summary>
        /// <param name="pieceName">nome da peça</param>
        /// <param name="colourBlack">cor da peça</param>
        public Rei(string pieceName, bool colourBlack)
        {
            this.pieceName = pieceName;
            this.colourBlack = colourBlack;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                      Variáveis                                                     *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool Check = false;          // Boolean que checka se o rei está em posição de check
        private bool checkMate = false;          // Boolean que checka se o jogo acabou ou seja caso o rei de uma das equipas seja comido

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                      Métodos                                                       *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Método mover do Rei
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Se pode mover ou não </returns>
        public override bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Mover em Volta da Peca

            // Move-se para a cima
            if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para baixo
            else if (pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a direita
            else if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a esquerda
            else if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal superior esquerda
            else if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal superior direita
            else if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal inferior direita
            else if (pecaOrigemLocalizacao.Y + 70  == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }           
            // Move-se para a diagonal inferior esquerda
            else if (pecaOrigemLocalizacao.Y + 70  == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
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
        /// Método comer do Rei
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Se pode mover ou não </returns>
        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            #region Mover em Volta da Peca

            // Move-se para a cima
            if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para baixo
            else if (pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a direita
            else if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a esquerda
            else if (pecaOrigemLocalizacao.Y == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal superior esquerda
            else if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal superior direita
            else if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal inferior direita
            else if (pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X + 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            // Move-se para a diagonal inferior esquerda
            else if (pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X - 70 == pecaDestinoLocalizacao.X)
            {
                return true;
            }
            else
            {
                return false;
            }

            #endregion
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                  Getters & Setters                                                 *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void setCheck(bool Check)
        {
            this.Check = Check;
        }

        public bool getCheck()
        {
            return Check;
        }

        public void setCheckMate(bool checkMate)
        {
            this.checkMate = checkMate;
        }

        public bool CheckMate()
        {
            return checkMate;
        }
    }
}
   