using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{
    /// <summary>
    /// Абстрактный класс Броня
    /// </summary>
    internal class Armor:Unit
    {
        private string name;
        private int defence;
        private string type;

        public string Name { get => name; set => name = value; }
        public int Defence { get => defence; set => defence = value; }
        public string Type { get => type; set => type = value; }
    }
}
