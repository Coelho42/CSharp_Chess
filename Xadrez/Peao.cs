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


        public override bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
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
        }
    }
}
    

                
                    
                           
                







         
               
   