using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{
    /// <summary>
    /// Абстрактынй класс описывающий бойцов
    /// </summary>
    internal class Unit : ILoot
    {

        private String name;


        private int? health;

        public ILoot[] loot;

    public string Name { get => name; set => name = value; }
    public int? Health { get => health; set => health = value; }

    }   
}