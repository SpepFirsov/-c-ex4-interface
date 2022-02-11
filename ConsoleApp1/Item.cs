using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{
    internal class Item:Unit,ILoot,IAction
    {
        private String name;
        private String descr;
        private string type;

        public string Name { get => name; set => name = value; }
        public string Descr { get => descr; set => descr = value; }
        public string Type { get => type; set => type = value; }
        public ILoot[] Loot { get; private set; }

        public void Buff(int treatment)
        {
            Health += treatment;
        }

        public void Debuff(int damage)
        {
            Health -= damage;
        }

        public ILoot[] Destroy()
        {
            return Loot;
        }
    }
}
