using System;
using System.Collections.Generic;


namespace ClassObjectsDemo
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
    class Employee
    {
        public void EDetails()
        {
            List<User> users = new List<User>(){
             new User {Id= 1, Name= "Praveen", Location= "TamilNadu"},
             new User {Id = 2, Name = "Anudeep", Location = "Hyderabad"}
          };
            users.Add(new User { Id = 3, Name = "Dummu", Location = "Guntur" });
            users.Add(new User { Id = 4, Name = "Alwin", Location = "Kerala" });
            Console.WriteLine("Count: " + users.Count);
            
            foreach (User u in users)
            {
                Console.WriteLine($"Id:{u.Id}, Name:{u.Name}, Location:{u.Location}");
            }
        }
    }
}
