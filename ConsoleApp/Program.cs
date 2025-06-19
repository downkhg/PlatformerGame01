﻿namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 김홍규 강사 입니다");
            //Console.WriteLine("Add:" + Add(10, 20));
            //ValMain();
            //CritcalAttackMain();//함수의 호출(사용)
            //PlayerAttakMain();
            //StageMain();
            //AttackWhile();
            //AttackCritcalWhile();
            //MonsterListMain();
            PlayerBattleMain(); // This call is now valid
        }

        static int Add(int a, int b)//10,20
        {
            int c = a + b; // 10 + 20 = 30
            return c; //30
        }

        static void ValMain()
        {
            int nScore = 0;
            float fRat = 1.0f / 4.0f;
            Console.WriteLine("Score:" + nScore);
            Console.WriteLine("Rat:" + fRat);
        }
        //몬스터가가 플레이어를 공격한다. ->몬스터가 공격했을때 (플레이어의 피)가 깍인다.
        //몬스터는 공격력 < 플레이어는 체력 제공, 공격:공격력으로 피를 깍는 행위.
        //데이터: 바뀌는 것. (체력), (몬스터공격력)
        //알고리즘: 몬스터의 공격력으로 플레이어의 체력을 깍는다. 체력 - 공격력
        //값을 설정하지않아서 작동하지않는다. 각 값을 공격력 10, 체력 100으로 설정한다.
        static void PlayerAttakMain()
        {
            int nMonsterAtk = 10;
            int nPlayerHP = 100;
            Console.WriteLine("몬스터의 공격력: " + nMonsterAtk + " 남은 hp:" + nPlayerHP);
            nPlayerHP = nPlayerHP - nMonsterAtk;
            Console.WriteLine("몬스터의 공격력: " + nMonsterAtk + " 남은 hp:" + nPlayerHP);
        }
        //플레이어가 (몬스터를) 공격을 할때 일정확률로 크리티컬이 터진다. 
        //플레이어가 공격 -> 플레이어의 공격력, 몬스터의 체력이 필요하다.
        //데이터: 플레이어의 공격력, 몬스터의 체력
        //알고리즘: 플레이어가 몬스터를 공격하는데, 일정확률로 크리티컬이 발생한다.
        //일정확률? -> 플레이어가 몬스터를 공격한다. -> 때릴때 일정확률로 크리티컬발생하고, 데미지가 1.5배가 된다.
        static void CritcalAttackMain()
        {
            Console.WriteLine("CritcalAttackMain");
            //1
            int nPlayerAtk = 10;
            //2
            int nMonsterHP = 100;
            Console.WriteLine("몬스터의 공격력: " + nPlayerAtk + " 남은 hp:" + nMonsterHP);
            //4 일정확률로 공격하기전에 데미지를 1.5배증가시킨다.
            Random cRandom = new Random();
            int nRandom = cRandom.Next(1, 3);// 1~2의 값이 나온다. 1/2
            //int nRandom = cRandom.Next(0, 3);// 0.1,2의 값이 나온다. 1/3
            /*
             if(nRandom == 1)
             {
                 Console.WriteLine("Critcal Attakc!");
                 nMonsterHP = nMonsterHP - (int)(nPlayerAtk *1.5f);//몬스터를 때린다.
             }
             else
                 nMonsterHP = nMonsterHP - nPlayerAtk;//몬스터를 때린다.
             */
            if (nRandom == 1)
            {
                Console.WriteLine("Critcal Attakc!");
                nPlayerAtk = (int)(nPlayerAtk * 1.5f);
            }

            nMonsterHP = nMonsterHP - nPlayerAtk;//몬스터를 때린다.
            //5
            Console.WriteLine("몬스터의 공격력: " + nPlayerAtk + " 남은 hp:" + nMonsterHP);
            Console.WriteLine("Random:" + nRandom);
        }
        //마을,필드,상점 중에서 이동장소를 입력하면 그 장소의 이름이 나오는 프로그램작성.
        //데이터: 마을,필드,상점, 입력값
        //알고리즘: 입력값 안내를 표시하는 메세지를 먼저 출력하고, 입력값이 마을이면 마을입니다 라고 출력하고 필드면.. 상점...
        static void StageMain()
        {
            string strTown = "마을";
            string strField = "사냥터";
            string strStore = "상점";
            Console.WriteLine("이동 할 장소를 입력하세요.(마을,사냥터,상점)");
            string strInput = Console.ReadLine();

            switch (strInput)
            {
                case "마을":
                    Console.WriteLine("마을 입니다.");
                    break;
                case "상점":
                    Console.WriteLine("상점 입니다.");
                    break;
                case "사냥터":
                    Console.WriteLine("사냥터 입니다.");
                    break;
                default:
                    Console.WriteLine("장소를 잘못입력했습니다.");
                    break;
            }
            /*
             if (strInput == strTown)
             {
                 Console.WriteLine("마을 입니다.");
             }
             else if (strInput == strField)
             {
                 Console.WriteLine("상점 입니다.");
             }
             else if (strInput == strStore)
             {
                 Console.WriteLine("사냥터 입니다.");
             }
             else
             {
                 Console.WriteLine("장소를 잘못입력했습니다.");
             }

             Console.WriteLine("StageMain");
             */
        }
        //몬스터가 플레이어를 (죽을때까지: 플레이어의 hp가 0이 될때) 공격한다.
        static void AttackWhile()
        {
            Console.WriteLine("AttackWile");
            int nMonsterAtk = 11;
            int nPlayerHP = 100;
            //살아있을때 공격을한다. //코드가 쉽다 -> 코드가 짧다. //햇깔리지않는다 -> 이조건을 그대로 생각한다.
            while (true)
            {
                Console.WriteLine("공격전, 몬스터의 공격력: " + nMonsterAtk + " 남은 hp:" + nPlayerHP);
                if (nPlayerHP <= 0) break;
                nPlayerHP = nPlayerHP - nMonsterAtk;
                Console.WriteLine("공격후, 몬스터의 공격력: " + nMonsterAtk + " 남은 hp:" + nPlayerHP);
            }
        }
        //몬스터가 플레이어를 죽을때까지 (일정확률로 크리티컬)이 발생 공격한다. 
        //몬스터가 플레이어를 죽을때까지 공격할때 공격하기전에 확률을 계산하여 크리티컬데미지를 추가하여 공격하고, 크리티컬이 터지지않으면, 데미지가 증가되지않는다.

        //몬스터가 플레이어를 공격한다.        
        //A.먼저 반복복을 돌리는 경우
        //1.몬스터가 플레이어를 일단 계속 공격한다 
        //2.플레이어가 언제죽었는지를 확인하고 조건문을 설정한다.
        //B.언제 플레이어가 살아있는지 확인한다.
        //1.몬스터가 살아 있을때만 공격해야한다. -> while문의 조건을 설정한다.
        //몬스터가 플레이어를 공격할때 (크리티컬이 발생하면 데미지가 1.5배 일시적으로 증가)한다.
        //몬스터가 플레이어를 공격할때(크리티컬이 발생하면 데미지가 일시적으로 1.5배 증가)되어 공격한다.
        static void AttackCritcalWhile()
        {
            Console.WriteLine("AttackCritcalWhile");
            int nMonsterAtk = 11;
            int nPlayerHP = 100;

            Random cRandom = new Random(); //랜덤을 생성한다. //랜덤기을 만든다.

            //살아있을때 공격을한다. //코드가 쉽다 -> 코드가 짧다. //햇깔리지않는다 -> 이조건을 그대로 생각한다.
            while (nPlayerHP > 0)
            {
                Console.WriteLine("공격전, 몬스터의 공격력: " + nMonsterAtk + " 남은 hp:" + nPlayerHP);
                //Random cRandom = new Random(); //랜덤을 하기전에 생성한다.
                int nRandom = cRandom.Next(1, 3);// 랜덤값을 생성한다. //랜덤기를 이용해서 숫자를 생성한다.
                if (nRandom == 1)
                {
                    int nCritcalAttack = (int)(nMonsterAtk * 1.5); //크리티컬데미지를 미리저장해서 알기쉽게 계산해둔다.
                    nPlayerHP = nPlayerHP - nCritcalAttack; //공격을할때 1회성으로 계산된 데미지를 사용한다.
                    Console.WriteLine("크리티컬 데미지: " + nCritcalAttack);
                }
                else
                    nPlayerHP = nPlayerHP - nMonsterAtk;

                Console.WriteLine("공격후, 몬스터의 공격력: " + nMonsterAtk + " 남은 hp:" + nPlayerHP);
                //랜덤을 끝나면 삭제한다. //랜덤기를 반복문이 종료될때 버린다.
            }
            //생성된 랜덤기를 삭제한다. //랜덤기를 함수가 종료될때 버린다.
        }
        //플레이어가 (공격:데미지)하면 몬스터는 (반격:맞고나서 공격(대상에게 데미지)을 하고, 둘중하나가 죽을때(플레이어나 몬스터의 hp가 0보다 작거나 같을때)까지 전투가 끝나지않고, 한쪽이 죽으면 끝남.
        //데이터: 플레이어의 공격력, 플레이어의 체력, 몬스터의 공격력, 몬스터의 체력
        //알고리즘: 플레이어가 먼저 공격하고, 몬스터가 맞고나서 공격 한다. 한쪽이 죽을때까지.

        static void PlayerBattleMain() // Changed from 'void' to 'static void'
        {
            Console.WriteLine("PlayerBattleMain");

            int nPlayerHP = 100; // Initialized for demonstration
            int nPlayerAtk = 10; // Initialized for demonstration

            int nMosterHP = 50;  // Initialized for demonstration
            int nMosterAtk = 5;  // Initialized for demonstration

            // Example battle logic (you'll need to expand this for a full battle)
            while (nPlayerHP > 0 && nMosterHP > 0)
            {
                // Player attacks monster
                nMosterHP = nMosterHP - nPlayerAtk;
                Console.WriteLine($"플레이어가 몬스터를 공격! 몬스터 남은 HP: {nMosterHP}");

                if (nMosterHP <= 0)
                {
                    Console.WriteLine("몬스터를 처치했습니다!");
                    break;
                }

                // Monster attacks player
                nPlayerHP = nPlayerHP - nMosterAtk;
                Console.WriteLine($"몬스터가 플레이어를 공격! 플레이어 남은 HP: {nPlayerHP}");

                if (nPlayerHP <= 0)
                {
                    Console.WriteLine("플레이어가 쓰러졌습니다!");
                    break;
                }
            }
        }

        static void MonsterListMain()
        {
            Console.WriteLine("MonsterListMain");
            List<string> listMonster = new List<string>();
            listMonster.Add("Slime");
            listMonster.Add("Skeleton");
            listMonster.Add("Zombie");
            listMonster.Add("Dragon");

            Console.WriteLine("[0]" + listMonster[0]);
            Console.WriteLine("[3]" + listMonster[3]);

            for (int i = 0; i < listMonster.Count; i++)
            {
                Console.WriteLine(string.Format("Monster[{0}]:{1}", i, listMonster[i]));
            }
        }

        static void MonsterSelectMain()
        {
            Console.WriteLine("이동 할 장소를 입력하세요.(평원,무덤,던전,계곡)");

            string strInput = Console.ReadLine();

            int nMonsterAttack = 10;
            int nMonsterHP = 100;

            switch (strInput)
            {
                case "평원":
                    Console.WriteLine("슬라임이 출연합니다.");
                    nMonsterAttack = 5;
                    nMonsterHP = 20;
                    break;
                case "무덤":
                    Console.WriteLine("스켈레톤 출연합니다.");
                    nMonsterAttack = 10;
                    nMonsterHP = 30;
                    break;
                case "던전":
                    Console.WriteLine("좀비 출연 합니다.");
                    nMonsterAttack = 20;
                    nMonsterHP = 50;
                    break;
                case "계곡":
                    Console.WriteLine("드래곤이 출연 합니다.");
                    nMonsterAttack = 50;
                    nMonsterHP = 200;
                    break;
                default:
                    Console.WriteLine("장소를 잘못입력했습니다.");
                    break;
            }

            //여기에 전투코드를 삽입하면 작동한다.
        }
    }
}