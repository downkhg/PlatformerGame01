using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class RPGPlayer
    {
        public static void BattleMain(Player player, Player monster)
        {
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

        public static void MonsterSelectMain()
        {
            Console.WriteLine("이동 할 장소를 입력하세요.(평원,무덤,던전,계곡)");

            string strInput = Console.ReadLine();

            int nMonsterAtk = 10;
            int nMonsterHP = 100;
            string strMonster = "none";

            switch (strInput)
            {
                case "평원":
                    Console.WriteLine("슬라임이 출연합니다.");
                    strMonster = "슬라임";
                    nMonsterAtk = 5;
                    nMonsterHP = 20;
                    break;
                case "무덤":
                    Console.WriteLine("스켈레톤 출연합니다.");
                    strMonster = "스켈레톤";
                    nMonsterAtk = 10;
                    nMonsterHP = 30;
                    break;
                case "던전":
                    Console.WriteLine("좀비 출연 합니다.");
                    strMonster = "좀비";
                    nMonsterAtk = 20;
                    nMonsterHP = 50;
                    break;
                case "계곡":
                    strMonster = "드래곤";
                    Console.WriteLine("드래곤이 출연 합니다.");
                    nMonsterAtk = 50;
                    nMonsterHP = 200;
                    break;
                default:
                    Console.WriteLine("장소를 잘못입력했습니다.");
                    break;
            }

            Player player = new Player("Player", 20, 10);
            Player monster = new Player(strMonster, nMonsterHP, nMonsterHP);

            BattleMain(player,monster);
        }

        public static void SelectFieldBattleMain()
        {
            List<Player> listMoster = new List<Player>();

            listMoster.Add(new Player("slime", 5, 20));
            listMoster.Add(new Player("skeleton", 10, 30));
            listMoster.Add(new Player("zombie", 20, 50));
            listMoster.Add(new Player("dragon", 50, 200));

            while (true)
            {
                int nSeletIdx = -1;
                Console.WriteLine("이동 할 장소를 입력하세요.(평원,무덤,던전,계곡)");

                string strInput = Console.ReadLine();

                switch (strInput)
                {
                    case "평원":
                        Console.WriteLine("슬라임이 출연합니다.");
                        nSeletIdx = 0;
                        break;
                    case "무덤":
                        Console.WriteLine("스켈레톤 출연합니다.");
                        nSeletIdx = 1;
                        break;
                    case "던전":
                        Console.WriteLine("좀비 출연 합니다.");
                        nSeletIdx = 2;
                        break;
                    case "계곡":
                        nSeletIdx = 3;
                        break;
                    default:
                        Console.WriteLine("장소를 잘못입력했습니다.");
                        break;
                }

                Player player = new Player("Player", 20, 10);
                Player monster = listMoster[nSeletIdx];

                BattleMain(player, monster);

                if (player.Death())
                {
                    Console.WriteLine("Game Over!");
                    break;
                }

                if (listMoster[3].Death())
                {
                    Console.WriteLine("The End!");
                    break;
                }

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
        //몬스터가 죽으면, 죽은몬스터로 부터 경험치를 가져온다.
        //데이터: 플레이어의 경험치, 몬스터의 경험치
        //알고리즘: 몬스터가 사망하면 플레어가 몬스터의 경험치를 가져온다.
        //렙업한다. 만약 경험치가 최대 경험치가되면 
        //데이터: 경험치,렙업,최대 경험치
        //알고리즘: 만약 경험치가 최대경험치보다 크다면, 레벨이 1 오른다.
        public StillExp(Player target)
        {

        }

        public void Display(string msg = "")
        {
            Console.WriteLine(msg);
            Console.WriteLine(Name + " Atk/HP:" + this.nAtk + "/" + this.nHP);
        }
    }
}
