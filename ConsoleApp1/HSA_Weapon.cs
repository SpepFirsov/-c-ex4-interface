using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{
    internal class HSA_Weapon : Weapon //HSA - ручное/холодное
    {
        private string name;
        private int crit_chance;
        private string material;
        public ILoot[] Loot { get; private set; }
        public string Name { get => name; set => name = value; }
        public int Crit_chance { get => crit_chance; set => crit_chance = value; }
        public string Material { get => material; set => material = value; }


    }
}
