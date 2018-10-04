using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCenter.Sdk.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            UserApi user = new UserApi("123", "123", "http://localhost:49420/api/v1/");
            User u = user.GetByIdAsync(1).Result;
            Console.WriteLine(u.Id + "," + u.NickName + "," + u.PhoneNum);
            Console.ReadKey();
        }
    }
}
