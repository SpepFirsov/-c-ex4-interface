using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{

    /// <summary>
    /// Абстрактный класс Добыча
    /// </summary>
    internal interface ILoot
    {
        private static string name;

        string Name { get; set; }

        void Loot()
        {

        }
    }
}