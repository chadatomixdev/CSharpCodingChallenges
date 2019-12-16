using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            var user1 = new User { Age = 25, Name = "Joe Soap" };
            var user2 = new User { Age = 13, Name = "Tim Neek" };
            var user3 = new User { Age = 55, Name = "Bob Durs" };
            var user4 = new User { Age = 31, Name = "Tina Tarn" };
            var user5 = new User { Age = 28, Name = "Ryan Ale" };
            var user6 = new User { Age = 32, Name = "Billy Rare" };
            var user7 = new User { Age = 74, Name = "Sara Sole" };
            var user8 = new User { Age = 48, Name = "Jessie Glass" };
            var user9 = new User { Age = 18, Name = "Vincent Peary" };
            var user10 = new User { Age = 22, Name = "Marcel Sharp" };
            var user11 = new User { Age = 21, Name = "Tracy Runn" };
            var user12 = new User { Age = 40, Name = "Suzette Bezuiden" };
            var user13 = new User { Age = 39, Name = "Charming Handsome" };

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);
            users.Add(user7);
            users.Add(user8);
            users.Add(user9);
            users.Add(user10);
            users.Add(user11);
            users.Add(user12);
            users.Add(user13);

            var newList = ReturnTop10FromList(users);

            foreach (var user in newList)
            {
                Console.WriteLine($"User { user.Name }, Age { user.Age } ");
            }
        }

        //Write a method to select the first 10 elements of a list and order by X
        public static IEnumerable<User> ReturnTop10FromList(List<User> users)
        {
            return users.OrderBy(u => u.Age).Take(10);
        }
    }
}
