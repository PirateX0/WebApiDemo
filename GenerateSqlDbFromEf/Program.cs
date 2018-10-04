using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCenter.Services;
using UserCenter.Services.Models;

namespace GenerateSqlDbFromEf
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UCDbContext ctx = new UCDbContext())
            {

                User user = new User();
                user.NickName = "dalong";
                user.PhoneNum = "123";
                user.PasswordHash = "123";
                user.PasswordSalt = "123";

                ctx.Users.Add(user);
                 ctx.SaveChanges();
            }

            Console.WriteLine("ok");

            Console.ReadKey();
        }
    }
}
