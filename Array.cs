using System;


namespace ClassObjectsDemo
{
    class Cars
    {
      public void CarBrand()
        {
            string[] brands = new string[4];
            brands[0] = "BMW";
            brands[1] = "Ferrari";
            brands[2] = "Lamborghini";
            brands[3] = "Audi";
          
            foreach(string item in brands)
            {
                Console.WriteLine(item);
            }
        }
        public void Racers()
        {
            string[] brands = { "BMW", "Ferrari", "Lamborghini", "Audi" };
            foreach (string item in brands)
            {
                Console.WriteLine(item);
            }
        }

    }
}
