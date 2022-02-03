using System;
namespace ClassObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Employee e1 = new Employee(752,23,"TamilNadu", "Praveen");
            Employee e2 = new Employee(754, 24, "Hyderabad", "Anudeep");
            e1.Display();
            e2.Display();

            Console.WriteLine("Enter the first value");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second value");
            int second = Convert.ToInt32(Console.ReadLine());



            e1.Sum(first, second);

        }
    }

    class Company
    {
        public string company = "Bhavna";
    }

    class Employee:Company
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
        public void Display()
        {
            Console.WriteLine($"employee id is:  { eid}");
            Console.WriteLine($"employee name is:  { ename}");
            Console.WriteLine($"employee age is:  { eage}");
            Console.WriteLine($"employee address is: { eaddress}");
            Console.WriteLine($" company name is:{company}");
        }
        public void Sum(int no1, int no2)
        {
            int res = no1 + no2;
            Console.WriteLine($"The value is  {res}");
        }
    }

}



