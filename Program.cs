using System;
namespace ClassObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(752, 23, "TamilNadu", "Praveen");
            Employee e2 = new Employee(754, 24, "Hyderabad", "Anudeep");
            e1.Display();
            e2.Display();

            e1.Multiply(12, 32);
            e1.Multiply(12, 32, 14);


            Console.WriteLine("Enter the first value");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second value");
            int second = Convert.ToInt32(Console.ReadLine());



            e1.Sum(first, second);


        }
    }
    abstract class Company
    {
        protected string company = "Bhavna";
        public abstract void Display();
        public virtual void Sum(int no1, int no2)
        {
            int res = no1 + no2;
            Console.WriteLine($"The value is  {res}");
        }
    }
    class Employee : Company
    {
        int eid, eage;
        string eaddress, ename;
        public Employee(int id, int age, string address, string name)
        {
            eid = id;
            eage = age;
            ename = name;
            eaddress = address;
        }
        public override void Display()
        {
            Console.WriteLine($"employee id is:  { eid}");
            Console.WriteLine($"employee name is:  { ename}");
            Console.WriteLine($"employee age is:  { eage}");
            Console.WriteLine($"employee address is: { eaddress}");
            Console.WriteLine($"company name is:{company}");
        }
        public override void Sum(int no1, int no2)
        {
            int res = no1 + no2;
            Console.WriteLine($"The value is  {res}");
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Multiply(int x, int y, int z)
        {
            Console.WriteLine(x * y * z);
        }
    }
}



