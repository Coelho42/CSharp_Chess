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
            
            bool possibleMove = false;

            // up right
            if (pecaOrigemLocalizacao.X > pecaDestinoLocalizacao.X) //ANDAR PARA A direita cima
            {
                if (pecaOrigemLocalizacao.Y < pecaDestinoLocalizacao.Y)
                {
                    if ((pecaOrigemLocalizacao.Y - pecaDestinoLocalizacao.Y) == (pecaDestinoLocalizacao.X - pecaOrigemLocalizacao.X)) // checks if they're diagonal
                    {
                        int y = pecaDestinoLocalizacao.X;
                        for (int x = pecaDestinoLocalizacao.Y; x <= pecaOrigemLocalizacao.Y; x = x - 70)
                        {
                            // checks if the piece checked is empty, if it is, sets the possibleMove to true
                            if (tabuleiro[x, y].getpieceName() == null)
                            {
                                possibleMove = true;
                            }
                            else
                            {
                                possibleMove = false;
                            }

                            // if it couldnt move at least once, it stops checking
                            if (possibleMove == false)
                            {
                                break;
                            }
                            y++;
                        }
                    }
                }
            }


            // up left
            if (pecaOrigemLocalizacao.X < pecaDestinoLocalizacao.X) //ANDAR PARA A esquerda cima
            {
                if (pecaOrigemLocalizacao.Y < pecaDestinoLocalizacao.Y)
                {
                    if ((pecaDestinoLocalizacao.Y - pecaOrigemLocalizacao.Y) == (pecaDestinoLocalizacao.X - pecaOrigemLocalizacao.X)) // checks if they're diagonal
                    {
                        int y = pecaDestinoLocalizacao.X;
                        for (int x = pecaDestinoLocalizacao.Y; x <= pecaOrigemLocalizacao.Y; x = x - 70)
                        {
                            // checks if the piece checked is empty, if it is, sets the possibleMove to true
                            if (tabuleiro[x, y].getpieceName() == null)
                            {
                                possibleMove = true;
                            }
                            else
                            {
                                possibleMove = false;
                            }

                            // if it couldnt move at least once, it stops checking
                            if (possibleMove == false)
                            {
                                break;
                            }
                            y++;
                        }
                    }
                }
            }

            // down right
            if (pecaOrigemLocalizacao.X > pecaDestinoLocalizacao.X) //ANDAR PARA A esquerda cima
            {
                if (pecaOrigemLocalizacao.Y > pecaDestinoLocalizacao.Y)
                {
                    if ((pecaOrigemLocalizacao.Y - pecaDestinoLocalizacao.Y) == (pecaOrigemLocalizacao.X - pecaDestinoLocalizacao.X)) // checks if they're diagonal
                    {
                        int y = pecaDestinoLocalizacao.X;
                        for (int x = pecaDestinoLocalizacao.Y; x >= pecaOrigemLocalizacao.Y; x = x + 70)
                        {
                            // checks if the piece checked is empty, if it is, sets the possibleMove to true
                            if (tabuleiro[x, y].getpieceName() == null)
                            {
                                possibleMove = true;
                            }
                            else
                            {
                                possibleMove = false;
                            }

                            // if it couldnt move at least once, it stops checking
                            if (possibleMove == false)
                            {
                                break;
                            }
                            y++;
                        }
                    }
                }
            }

            // down left
            if (pecaOrigemLocalizacao.X < pecaDestinoLocalizacao.X) //ANDAR PARA A esquerda cima
            {
                if (pecaOrigemLocalizacao.Y > pecaDestinoLocalizacao.Y)
                {
                    if ((pecaDestinoLocalizacao.Y - pecaOrigemLocalizacao.Y) == (pecaOrigemLocalizacao.X - pecaDestinoLocalizacao.Y)) // checks if they're diagonal
                    {
                        int y = pecaDestinoLocalizacao.X;
                        for (int x = pecaDestinoLocalizacao.Y; x >= pecaOrigemLocalizacao.Y; x = x + 70)
                        {
                            // checks if the piece checked is empty, if it is, sets the possibleMove to true
                            if (tabuleiro[x, y].getpieceName() == null)
                            {
                                possibleMove = true;
                            }
                            else
                            {
                                possibleMove = false;
                            }

                            // if it couldnt move at least once, it stops checking
                            if (possibleMove == false)
                            {
                                break;
                            }
                            y++;
                        }
                    }
                }
            }

            // If it's possible to move then execute the move method
            if (possibleMove)
            {
                return true;        
            }
            else
            {
                return false;
            }          
        }
    }
}

