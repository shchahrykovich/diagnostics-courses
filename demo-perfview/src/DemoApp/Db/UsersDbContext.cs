using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Db
{
    #region Users

    public class User0
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    public class User1
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    public class User2
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    public class User3
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    public class User4
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    public class User5
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    public class User6
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    public class User7
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    public class User8
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }

    #endregion

    public class UsersDbContext : DbContext
    {
        public DbSet<User0> Users0 { get; set; }
        public DbSet<User1> Users1 { get; set; }
        public DbSet<User2> Users2 { get; set; }
        public DbSet<User3> Users3 { get; set; }
        public DbSet<User4> Users4 { get; set; }
        public DbSet<User5> Users5 { get; set; }
        public DbSet<User6> Users6 { get; set; }
        public DbSet<User7> Users7 { get; set; }
        public DbSet<User8> Users8 { get; set; }
    }
}