using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{

    /// <summary>
    /// Абстрактный класс Оружие
    /// </summary>
    internal abstract class Weapon:Unit,ILoot
    {
        private string name;
        private int damage;
        private string type;

        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }
        public string Type { get => type; set => type = value; }

        public ILoot Use ()
        {
            return this;
        }



    }
}