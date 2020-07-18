using System;

namespace Day4
{
    //OZN
    class Student
    {
        private string regNo;
        public void setRegNo(string regNo)
        {

            this.regNo = regNo;

        }


        public string RegNo { get; set; }


        public string getRegNo()
        {
            return  "OZN_"+regNo;
        }




        private int atmNo;

        public void setAtmNo(int atmNo)
        {
            this.atmNo = atmNo;

        }

        public int getAtmNo()
        {
            return atmNo;
        }

       
        private int m1;

      
        private string name;

        public int age;




        private int rollNo;
        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }

        public int getRollNo()
        {
            return rollNo;
        }

    


    }



    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            s1.age = 10;

          
            //Console.WriteLine(s1.age);
            
            
            //s1.setRollNo(1000);

            //Console.WriteLine(s1.getRollNo());

            Console.WriteLine("Enter regno");
            s1.setRegNo(Console.ReadLine());

            Console.WriteLine(s1.getRegNo());

        }
    }
}
