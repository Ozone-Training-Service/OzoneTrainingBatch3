﻿using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
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
        public int avg;

        
        public void display()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter roll");
            roll= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter m1 and m2");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2;
            avg = total / 2;
            if (avg > 80 && avg <= 100)
            {
                Console.WriteLine("A grade");

                if (avg > 60 && avg <= 80)
                {
                    Console.WriteLine("B grade");
                }
            }
            else if(avg>40 && avg<=60)
            {
                Console.WriteLine("c grade");
            }
            else
            {
                Console.WriteLine("d grade");
                Console.WriteLine("you re failed");
            }




        }


    }

    class Test
    {

        static void Main(string[] args)
        {



            
            Student s1 = new Student();
            s1.display();
            Student s2 = new Student();
            s2.display();
            Student s3 = new Student();
            s3.display();




            Console.WriteLine("\t\t Report\n");
            Console.WriteLine("\t\t____________");
            Console.WriteLine("Name          {0}",s1.name);
            Console.WriteLine("roll          {0}", s1.roll);
            Console.WriteLine("M1             {0}",s1.m1);
            Console.WriteLine("m2              {0}",s1.m2);
            Console.WriteLine("Total              {0}", s1.total);
            Console.WriteLine("avg              {0}", s1.avg);

            Console.WriteLine("\t\t Report\n");
            Console.WriteLine("\t\t____________");
            Console.WriteLine("Name          {0}", s2.name);
            Console.WriteLine("roll          {0}", s2.roll);
            Console.WriteLine("M1             {0}", s2.m1);
            Console.WriteLine("m2              {0}", s2.m2);
            Console.WriteLine("Total              {0}", s2.total);
            Console.WriteLine("avg              {0}", s2.avg);

            Console.WriteLine("\t\t Report\n");
            Console.WriteLine("\t\t____________");
            Console.WriteLine("Name          {0}", s3.name);
            Console.WriteLine("roll          {0}", s3.roll);
            Console.WriteLine("M1             {0}", s3.m1);
            Console.WriteLine("m2              {0}", s3.m2);
            Console.WriteLine("Total              {0}", s3.total);
            Console.WriteLine("avg              {0}", s3.avg);





            Console.ReadKey();

        }
    }
}
