using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xadrez
{
    class Peca : PictureBox
    {
        protected string pieceName;
        protected bool? colourBlack;
        protected bool Alive = true;
        protected bool Check;


        public virtual bool Mover(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            return true;
        }

        public virtual bool Comer(Peca[,] tabuleiro, Point pecaOrigemLocalizacao, Point pecaDestinoLocalizacao, bool player1Turn)
        {
            return true;
        }

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

        public void setAlive(bool Alive)
        {
            this.Alive = Alive;
        }

        public bool getAlive()
        {
            return Alive;
        }  
    }
}
    




       


