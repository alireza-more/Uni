using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uni.Data
{
    public static class Seed
    {
        public static void addUsers(Data.UniContext ctx)
        {
            //1
            ctx.User.Add(new User()
            {
                Email="alireza.sejdei@gmail.com",
                Name="علیرضا سجده ای",
                Phone="09308311100"
            });
            //2
            ctx.User.Add(new User()
            {
                Email = "test1@gmail.com",
                Name = "مرضیه ایروانی",
                Phone = "09107102610"
            });
            //3
            ctx.User.Add(new User()
            {
                Email = "text2@gmail.com",
                Name = "ابراهیم جهانگرد",
                Phone = "09127122612"
            });

            ctx.SaveChanges();
        }
    }
}
