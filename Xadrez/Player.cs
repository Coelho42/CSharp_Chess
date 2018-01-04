using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Player
    {
        private string playerId;
        private bool corPeca;
        private long nPecas;

       
        public void setplayerId(string playerId)
        {
            this.playerId = playerId;
        }

        public string getplayerId()
        {
            return playerId;
        }

        public void setcorPeca(bool corPeca)
        {
            this.corPeca = corPeca;
        }

        public bool getcorPeca()
        {
            return corPeca;
        }

        public void setnPecas(long nPecas)
        {
            this.nPecas = nPecas;
        }

        public long getnPecas()
        {
            return nPecas;
        }
    }
}
