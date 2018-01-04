using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Peao : Peca
    {
        private bool Trade = false;

        public override bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            if (player1Turn == true)
            {
                if (pecaOrigemLocalizacao.Y == 70)
                {
                    if ((pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X) || (pecaOrigemLocalizacao.Y + 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X))
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
                    if (pecaOrigemLocalizacao.Y + 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }                           
            }                   
            else 
            {
                if (pecaOrigemLocalizacao.Y == 420)
                {
                    if ((pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X) || (pecaOrigemLocalizacao.Y - 140 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X))
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
                    if (pecaOrigemLocalizacao.Y - 70 == pecaDestinoLocalizacao.Y && pecaOrigemLocalizacao.X == pecaDestinoLocalizacao.X)
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


        public override void Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {

            if (player1Turn == true)
            {
                if (tabuleiro[pecaDestinoLocalizacao.X + 70, pecaDestinoLocalizacao.Y + 70].getcolourBlack() == false)
                {
                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                    {
                        for (int j = 0; j < tabuleiro.GetLength(1); j++)
                        {
                            if (tabuleiro[i, j].Location == pecaDestinoLocalizacao)
                            {
                                tabuleiro[i, j].Image = null;
                                tabuleiro[i, j].setcolourBlack(null);
                                tabuleiro[i, j].setpieceName(null);                             
                            }                          
                        }
                    }
                }
                else
                {
                    if (tabuleiro[pecaDestinoLocalizacao.X - 70, pecaDestinoLocalizacao.Y + 70].getcolourBlack() == false)
                    {
                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                        {
                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                            {
                                if (tabuleiro[i, j].Location == pecaDestinoLocalizacao)
                                {
                                    tabuleiro[i, j].Image = null;
                                    tabuleiro[i, j].setcolourBlack(null);
                                    tabuleiro[i, j].setpieceName(null);
                                }
                            }
                        }
                    }
                }                                     
            }
            else
            {
                if (tabuleiro[pecaDestinoLocalizacao.X + 70 , pecaDestinoLocalizacao.Y - 70].getcolourBlack() == true)
                {
                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                    {
                        for (int j = 0; j < tabuleiro.GetLength(1); j++)
                        {
                            if (tabuleiro[i, j].Location == pecaDestinoLocalizacao)
                            {
                                tabuleiro[i, j].Image = null;
                                tabuleiro[i, j].setcolourBlack(null);
                                tabuleiro[i, j].setpieceName(null);
                            }
                        }
                    }
                }
                else
                {
                    if (tabuleiro[pecaDestinoLocalizacao.X - 70, pecaDestinoLocalizacao.Y - 70].getcolourBlack() == true)
                    {
                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                        {
                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                            {
                                if (tabuleiro[i, j].Location == pecaDestinoLocalizacao)
                                {
                                    tabuleiro[i, j].Image = null;
                                    tabuleiro[i, j].setcolourBlack(null);
                                    tabuleiro[i, j].setpieceName(null);
                                }
                            }
                        }
                    }                      
                }
            }         
        }
    }
}

   