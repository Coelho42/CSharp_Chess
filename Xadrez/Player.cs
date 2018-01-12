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
      
        public void setplayerId(string playerId)
        {
            this.playerId = playerId;
        }

        public string getplayerId()
        {
            return playerId;
        }
    }
}
