namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! 김홍규 강사 입니다");
            Console.WriteLine("Add:" + Add(10, 20));
            ValMain();
            CritcalAttackMain();
            StageMain();
            AttackWile();
            MonsterListMain();
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
