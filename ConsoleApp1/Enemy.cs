using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{
    internal class Enemy : Unit, IAction
    {
        private Weapon c_weapon;
        private Armor c_armor_t;
        private Armor c_armor_h;
        private Armor c_armor_l;



        public ILoot[] Loot { get; internal set; }
        public int Money { get; internal set; }

        internal Weapon C_weapon { get => c_weapon; set => c_weapon = value; }
        internal Armor C_armor_t { get => c_armor_t; set => c_armor_t = value; }
        internal Armor C_armor_h { get => c_armor_h; set => c_armor_h = value; }
        internal Armor C_armor_l { get => c_armor_l; set => c_armor_l = value; }

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
