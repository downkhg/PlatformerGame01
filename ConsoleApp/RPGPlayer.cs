using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class RPGPlayer
    {
        public static void ClassPlayerBattleMain()
        {
            Player player = new Player("Player", 20, 10);
            Player monster = new Player("Monster", 20, 10);

            while (!player.Death() && !monster.Death())
            {
                if (player.Death() == false)
                {
                    Console.WriteLine("=========Player Trun===========");
                    player.Attack(monster);
                    player.Display();
                    monster.Display();
                }
                else
                    Console.WriteLine("Player Death!");

                if (monster.Death() == false)
                {
                    Console.WriteLine("=========Monster Trun===========");
                    monster.Attack(player);
                    player.Display();
                    monster.Display();

                }
                else
                    Console.WriteLine("Monster Death!");

                Console.WriteLine("==============================");
            }
        }
    }
    class Player
    {
        public string Name { get; set; }
        int nAtk;
        int nHP;

        public Player(string name, int hp = 100, int atk = 10)
        {
            Name = name;
            nAtk = atk;
            nHP = hp;
        }

        public void Attack(Player target)
        {
            target.nHP = target.nHP - this.nAtk;
            //target.nHP -= this.nAtk;
        }

        public bool Death()
        {
            if (this.nHP <= 0)
                return true;
            else
                return false;
        }

        public void Display(string msg = "")
        {
            Console.WriteLine(msg);
            Console.WriteLine(Name + " Atk/HP:" + this.nAtk + "/" + this.nHP);
        }
    }
}
