using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{
    internal class Money:Unit,ILoot
    {
        private int money;

        public int GetMoney()
        {
            return money;
        }

        public void SetMoney(int value)
        {
            money = value;
        }
    }
}
