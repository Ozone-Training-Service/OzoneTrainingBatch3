using System;

namespace Day2
{

    class Sample
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        public int GetMeARandomNum()
        {
            Random rn = new Random();

            int num = rn.Next(100);


            return num;
        }


        public void Sum(int x, int y)
        {


            Console.WriteLine("{0}+{1}={2}",x,y,(x+y));
        }


        public int Sub(int x, int y)
        {


            return (x - y);
        }



    }

    class Program
    {
        static void Main(string[] args)
        {

            Sample o = new Sample();
            o.Hello();

            int x=o.GetMeARandomNum();
           
            
            Console.WriteLine("Random num="+x);

            o.Sum(10,10);

            int ans = o.Sub(10,5);
            Console.WriteLine("Sub="+ans);

            Console.ReadKey();
        }
    }
}
