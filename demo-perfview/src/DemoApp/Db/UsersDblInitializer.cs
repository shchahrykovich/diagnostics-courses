using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Db
{
    public class UsersDblInitializer : DropCreateDatabaseAlways<UsersDbContext>
    {
        protected override void Seed(UsersDbContext context)
        {
        }
    }
}