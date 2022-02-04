﻿using System;
namespace ClassObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Details details = new Details(752, 23, "TamilNadu", "Praveen");//object for child class of (Company)

            details.Display();


            details.Projects("GHX", "ConnectWise");
            details.Projects("elamica", "MeredialLink", "TechnologyAdvice");


            Console.WriteLine("Enter the first value");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the Second value");
            string second = Console.ReadLine();

            details.fullname(first, second);
        }
    }


    //abstract class
    //parent class
    abstract class Company
    {
        //data hiding
        protected string company = "Bhavna";
        public abstract void Display();
        public virtual void fullname(string no1, string no2)
        {
            string res = no1 + no2;
            Console.WriteLine($"name  {res}");
        }
    }

    //child class
    class Details : Company
    {
        int eid, eage;
        string eaddress, ename;

        //constructor
        public Details(int id, int age, string address, string name)
        {
            eid = id;
            eage = age;
            ename = name;
            eaddress = address;
        }

        //abstract method
        public override void Display()
        {
            Console.WriteLine($"employee id is:  { eid}");
            Console.WriteLine($"employee name is:  { ename}");
            Console.WriteLine($"employee age is:  { eage}");
            Console.WriteLine($"employee address is: { eaddress}");
            Console.WriteLine($"company name is:{company}");
        }


        //overriding
        public override void fullname(string fname, string lname)
        {
            string res = fname + lname;
            Console.WriteLine($"Fullname is  {res}");
        }

        //overloading 
        public void Projects(string p_one, string p_two)
        {
            Console.WriteLine($"project number 1 is:{p_one}");
            Console.WriteLine($"project number 2 is:{p_two}");
        }

        //overloading
        public void Projects(string p_one, string p_two, string p_three)
        {
            Console.WriteLine($"project number 1 is:{p_one}");
            Console.WriteLine($"project number 2 is:{p_two}");
            Console.WriteLine($"project number 3 is:{p_three}");
        }
    }
}



