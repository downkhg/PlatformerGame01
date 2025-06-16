namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! 김홍규 강사 입니다");
            Console.WriteLine("Add:" + Add(10, 20));
            ValMain();
            CritcalAttackMain();//함수의 호출(사용)
            PlayerAttakMain();
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
        //변수: 바뀌는 것. (체력), (몬스터공격력)
        //알고리즘: 몬스터의 공격력으로 플레이어의 체력을 깍는다. 체력 - 공격력
        //값을 설정하지않아서 작동하지않는다. 각 값을 공격력 10, 체력 100으로 설정한다.
        static void PlayerAttakMain()
        {
            int nMonsterAtk = 10;
            int nPlayerHP = 100;
            Console.WriteLine("남은 hp" + nPlayerHP);
            nPlayerHP = nPlayerHP - nMonsterAtk;
            Console.WriteLine("남은 hp" + nPlayerHP);
        }
        //플레이어가 공격을 할때 일정확률로 크리티컬이 터진다. 
        static void CritcalAttackMain()
        {
            Console.WriteLine("CritcalAttackMain");
        }

        static void StageMain()
        {
            Console.WriteLine("StageMain");
        }

        static void AttackWile()
        {
            Console.WriteLine("AttackWile");
        }

        static void MonsterListMain()
        {
            Console.WriteLine("MonsterListMain");
        }
    }
}
