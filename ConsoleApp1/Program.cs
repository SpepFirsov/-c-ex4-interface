using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chr_id=0;
            string playerch;
            ///////добавление контента//////
            ///
            Item bandage_v1 = new Item();
            bandage_v1.Name = "Army bondage";
            bandage_v1.Descr = "Classic bondage from army,heals 50 health";
            bandage_v1.Type = "Heal item";

            Item sp1 = new Item();
            sp1.Name = "Broken handgun";
            sp1.Descr = "Have some bullets in, but cant shoot";
            sp1.Type = "Special";


            HSA_Weapon knife1 = new HSA_Weapon();
            knife1.Name = "Battle knife";
            knife1.Crit_chance = 10;
            knife1.Material = "Steel";
            knife1.Type = "Handheld/Steel arms";
            knife1.Damage = 30;

            HSA_Weapon club1 = new HSA_Weapon();
            club1.Name = "Club";
            club1.Crit_chance = 10;
            club1.Material = "Steel";
            club1.Type = "Handheld/Steel arms";
            club1.Damage = 25;

            Armor vest1 = new Armor();
            vest1.Name = "Army vest A20";
            vest1.Defence = 15;
            vest1.Type = "torso";

            Armor helmet1 = new Armor();
            helmet1.Name = "Army helmet TR2";
            helmet1.Defence = 10;
            helmet1.Type = "helmet";

            Armor pb1 = new Armor();
            pb1.Name = "Army pants n boots GP4";
            pb1.Defence = 5;
            pb1.Type = "pants n boots";

            /////////////////////////////
            Armor vest2 = new Armor();
            vest2.Name = "Army vest B20";
            vest2.Defence = 10;
            vest2.Type = "torso";

            Armor helmet2 = new Armor();
            helmet2.Name = "Army helmet CG3";
            helmet2.Defence = 10;
            helmet2.Type = "helmet";

            Armor pb2 = new Armor();
            pb2.Name = "Army pants n boots GP2";
            pb2.Defence = 2;
            pb2.Type = "pants n boots";
            //////////пустая броня////////////
            Armor none_t = new Armor();
            none_t.Name = "none";
            none_t.Defence = 4;
            none_t.Type = "torso";

            Armor none_h = new Armor();
            none_h.Name = "";
            none_h.Defence = 2;
            none_h.Type = "helmet";

            Armor none_pb = new Armor();
            none_pb.Name = "";
            none_pb.Defence = 4;
            none_pb.Type = "pants n boots";
            //////////////////////
            Soldier soldier = new Soldier();
            soldier.Name = "Jack";
            soldier.Health = 100;
            soldier.Loot = new ILoot[10];
            soldier.C_weapon = club1;
            soldier.C_armor_h = helmet1;
            soldier.C_armor_t = vest1;
            soldier.C_armor_l = pb1;
            soldier.Money = 50;
            soldier.Loot[0] = bandage_v1;

            Soldier soldier2 = new Soldier();
            soldier2.Name = "Lucas";
            soldier2.Health = 85;
            soldier2.Loot = new ILoot[7];
            soldier2.C_weapon = club1;
            soldier2.C_armor_h = helmet2;
            soldier2.C_armor_t = vest2;
            soldier2.C_armor_l = pb2;
            soldier2.Money = 75;
            soldier2.Loot[0] = bandage_v1;



            Enemy crook1 = new();
            
            crook1.Name = "Crookerguy";
            crook1.Health = 100;
            crook1.Loot = new ILoot[5];
            crook1.C_weapon = knife1;
            crook1.C_armor_h = none_h;
            crook1.C_armor_t = none_t;
            crook1.C_armor_l = none_pb;
            crook1.Money = 25;
            crook1.Loot[0] = sp1;
            crook1.Loot[0].Name = sp1.Name;
            if (crook1.Health < 0)
            {
                crook1.Destroy();
            }

            Unit unit = new Unit();
    
            if (soldier.Health < 0)
            {
                soldier.Destroy();
            }

            ////////
            Console.WriteLine("choose character(enter number or full name)");
            Console.WriteLine("1.Jack");
            Console.WriteLine("2.Lucas");
            playerch = Console.ReadLine();
            if (playerch == "1")
            {
                chr_id = 1;
                Console.WriteLine("Choosed Jack");
                playerch = "Jack";
            }
            else if (playerch == "2")
            {
                chr_id = 2;
                Console.WriteLine("Choosed Lucas");
                playerch = "Lucas";
            }
            else if (playerch == "Jack")
            {
                chr_id = 1;
                Console.WriteLine("Choosed Jack");
                playerch = "Jack";
            }
            else if (playerch == "Lucas")
            {
                chr_id = 2;
                Console.WriteLine("Choosed Lucas");
                playerch = "Lucas";
            }
            else if (playerch == "jack")
            {
                chr_id = 1;
                Console.WriteLine("Choosed Jack");
                playerch = "Jack";
            }
            else if (playerch == "lucas")
            {
                chr_id = 2;
                Console.WriteLine("Choosed Lucas");
                playerch = "Lucas";
            }
            //////////
            Console.WriteLine("------");
            Console.WriteLine("Actions");
            Console.WriteLine("1.Player info");
            string? playerch2 = Console.ReadLine();
            if (playerch == "Jack" || chr_id == 1)
            {
                Console.WriteLine("Name :" + soldier.Name);
                Console.WriteLine("Health:" + soldier.Health);
                Console.WriteLine("Inventory slots:10");
                Console.WriteLine("Current weapon:" + soldier.C_weapon.Name);
                Console.WriteLine("Armor:" + soldier.C_armor_h.Name + ", " + soldier.C_armor_t.Name + ", " + soldier.C_armor_l.Name);             
                Console.WriteLine("Money:" + soldier.Money);
                Console.WriteLine("Inventory:" + soldier.Loot[0]);
            }
            else if (playerch == "Lucas" || chr_id == 2)
            {
                Console.WriteLine("Name :" + soldier2.Name);
                Console.WriteLine("Health:" + soldier2.Health);
                Console.WriteLine("Inventory slots:7");
                Console.WriteLine("Current weapon:" + soldier2.C_weapon.Name);
                Console.WriteLine("Armor:" + soldier2.C_armor_h.Name + ", " + soldier2.C_armor_t.Name + ", " + soldier2.C_armor_l.Name);
                Console.WriteLine("Money:" + soldier2.Money);
                Console.WriteLine("Inventory:" + soldier2.Loot[0].Name);
            }

        }
      
    }
}
