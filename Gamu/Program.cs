using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gamu
{
    class Program
    {

        static void Main(string[] args)
        {
            bool chooseclass = false;
            Player nu = new Player();
            do
            {
                Console.WriteLine("Choose class");
                Console.WriteLine("Warrior");
                Console.WriteLine("Mage");
                Console.WriteLine("Thief");
                Player.Job = Console.ReadLine().ToUpper();
                if (Player.Job == "WARRIOR")
                {
                    nu.Warrior();
                    chooseclass = true;
                }
                else if (Player.Job == "MAGE")
                {
                    nu.Mage();
                    chooseclass = true;
                }
                else if (Player.Job == "THIEF")
                {
                    nu.Thief();
                    chooseclass = true;
                }
            }
            while (chooseclass == false);
            Console.WriteLine("You have chosen " + Player.Job + " and these are your stats " + "HP: " + nu.MaxHP + " SP: " + nu.SP);
            Console.ReadLine();
        }
    }
public class Player
    {
        public int CurrentHitPoints { get; set; }
        public int MaxHP { get; set; }
        public int SP { get; set; }
        public int Yen { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Int { get; set; }
        public int Ability { get; set; }
        public int EXP = 0;
        public int LVL = 1;
        public static string Job { get; set; }
        public void Warrior()
        {
            MaxHP = 50;
            SP = 50;
            Attack = 20;
            Int = 5;
            Ability = 10;
        }
        public void Mage()
        {
            MaxHP = 25;
            SP = 100;
            Attack = 5;
            Int = 20;
            Ability = 15;
        }
        public void Thief()
        {
            MaxHP = 35;
            SP = 75;
            Attack = 10;
            Int = 5;
            Ability = 25;
        }
    }
}