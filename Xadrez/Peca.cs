﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xadrez
{
    /*
      * Super Classe Peca: 
      * 
      * Esta classe é a base de todo o programa, e de é de onde todas as subclasses herandam os seus métodos e atributos, este tambem contem os getters & setters que são usados na main
      * e nas classes pelos métodos mover e comer.
      * 
      */
    class Peca : PictureBox
    {

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                      Variáveis                                                     *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        protected string pieceName;     // String para o nome da peça
        protected bool? colourBlack;    // Boolean que checka se peça é preta ou branca
        protected bool check;           // Bool para se a peça estiver em posição de check
        protected bool firstMove = true;       // Bool que verifica se é a primeira jogada da peça

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                      Métodos                                                       *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Metodo Mover
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Boolean que checka se pode mover ou não </returns>
        public virtual bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            return true;
        }

        /// <summary>
        /// Método Comer
        /// </summary>
        /// <param name="tabuleiro"> Recebe o tabuleiro da Main </param>
        /// <param name="pecaOrigemLocalizacao"> Localização da peça selecionada </param>
        /// <param name="pecaDestinoLocalizacao"> Localização para onde a peça se vai mover no tabuleiro </param>
        /// <param name="player1Turn"> Recebe o turno do jogador </param>
        /// <returns> Boolean que checka se pode comer ou não </returns>
        public virtual bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            return true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //*                                                                                                                    *//  
        //*                                                  Getters & Setters                                                 *//    
        //*                                                                                                                    *//             
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void setcolourBlack(bool? colourBlack)
        {
            this.colourBlack = colourBlack;
        }
        
        public bool? getcolourBlack()
        {
            return colourBlack;
        }

        public void setpieceName(string pieceName)
        {
            this.pieceName = pieceName;
        }

        public string getpieceName()
        {
            return pieceName;
        }

        public void setcheck(bool check)
        {
            this.check = check;
        }

        public bool getcheck()
        {
            return check;
        }

        public void setfirstMove(bool firstMove)
        {
            this.firstMove = firstMove;
        }

        public bool getfirstMove()
        {
            return firstMove;
        }
    }
}
    




       


