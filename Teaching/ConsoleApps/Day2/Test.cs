using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Student
    {
        public int roll;
        public int m1;
        public int m2;
        public int total;
        public string name;

        public void Total()
        {
            total = m1 + m2;
        }


    }

    class Test
    {

        static void Main(string[] args)
        {



            
            Student s1 = new Student();
            Console.WriteLine("Enter Name");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter m1 and m2");
            s1.m1 = Convert.ToInt32(Console.ReadLine());
            s1.m2 = Convert.ToInt32(Console.ReadLine());

            s1.total = s1.m1 + s1.m2;

            Console.WriteLine("\t\t Report\n");
            Console.WriteLine("\t\t____________");
            Console.WriteLine("Name          {0}",s1.name);
            Console.WriteLine("M1             {0}",s1.m1);
            Console.WriteLine("m2              {0}",s1.m2);
            Console.WriteLine("Total              {0}", s1.total);


            Console.ReadKey();

        }
    }
}
