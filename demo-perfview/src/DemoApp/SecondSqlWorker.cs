using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.Db;

namespace DemoApp
{
    internal class SecondSqlWorker
    {
        private CancellationToken _token;
        private Random _rand;

        public SecondSqlWorker(CancellationToken token)
        {
            _token = token;
            _rand = new Random(Guid.NewGuid().GetHashCode());
        }

        public void Run()
        {
            while (!_token.IsCancellationRequested)
            {
                using (UsersDbContext context = new UsersDbContext())
                {
                    int count = 0;

                    var currentSecond = DateTime.UtcNow.Second;
                    if (currentSecond % 5 == 0)
                    {
                        count = ExecuteQueries1(context);
                    }
                    else
                    {
                        count = ExecuteQueries2(context);
                    }
                    WaitHandle.WaitAll(new[] { _token.WaitHandle }, TimeSpan.FromMilliseconds(50 + count));
                }
            }
        }

        private int ExecuteQueries1(UsersDbContext context)
        {
            var users0 = context.Users0.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();
            var users1 = context.Users1.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();
            var users2 = context.Users2.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();
            var users3 = context.Users3.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();
            var users4 = context.Users4.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();
            var users5 = context.Users5.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();
            var users6 = context.Users6.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();
            var users7 = context.Users7.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();
            var users8 = context.Users8.Where(u => u.Age == 20 && u.FirstName == "2").ToArray();

            int count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            var date = DateTime.Now.AddDays(-1);
            users0 = context.Users0.Where(u => u.CreateDate == date && u.Height > 180).ToArray();
            users1 = context.Users1.Where(u => u.CreateDate == date && u.Height > 180).ToArray();
            users2 = context.Users2.Where(u => u.CreateDate == date && u.Height > 180).ToArray();
            users3 = context.Users3.Where(u => u.CreateDate == date && u.Height > 180).ToArray();
            users4 = context.Users4.Where(u => u.CreateDate == date && u.Height > 180).ToArray();
            users5 = context.Users5.Where(u => u.CreateDate == date && u.Height > 180).ToArray();
            users6 = context.Users6.Where(u => u.CreateDate == date && u.Height > 180).ToArray();
            users7 = context.Users7.Where(u => u.CreateDate == date && u.Height > 180).ToArray();
            users8 = context.Users8.Where(u => u.CreateDate == date && u.Height > 180).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            date = DateTime.Now.AddHours(-25);
            var age = _rand.Next();
            users0 = context.Users0.Where(u => u.CreateDate == date && u.Age == age).ToArray();
            users1 = context.Users1.Where(u => u.CreateDate == date && u.Age == age).ToArray();
            users2 = context.Users2.Where(u => u.CreateDate == date && u.Age == age).ToArray();
            users3 = context.Users3.Where(u => u.CreateDate == date && u.Age == age).ToArray();
            users4 = context.Users4.Where(u => u.CreateDate == date && u.Age == age).ToArray();
            users5 = context.Users5.Where(u => u.CreateDate == date && u.Age == age).ToArray();
            users6 = context.Users6.Where(u => u.CreateDate == date && u.Age == age).ToArray();
            users7 = context.Users7.Where(u => u.CreateDate == date && u.Age == age).ToArray();
            users8 = context.Users8.Where(u => u.CreateDate == date && u.Age == age).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            date = DateTime.Now.AddHours(-25);
            var name = _rand.Next().ToString();
            age = _rand.Next();
            users0 = context.Users0.Where(u =>u.LastName == name && u.Height < age).ToArray();
            users1 = context.Users1.Where(u =>u.LastName == name && u.Height < age).ToArray();
            users2 = context.Users2.Where(u =>u.LastName == name && u.Height < age).ToArray();
            users3 = context.Users3.Where(u =>u.LastName == name && u.Height < age).ToArray();
            users4 = context.Users4.Where(u =>u.LastName == name && u.Height < age).ToArray();
            users5 = context.Users5.Where(u =>u.LastName == name && u.Height < age).ToArray();
            users6 = context.Users6.Where(u =>u.LastName == name && u.Height < age).ToArray();
            users7 = context.Users7.Where(u =>u.LastName == name && u.Height < age).ToArray();
            users8 = context.Users8.Where(u =>u.LastName == name && u.Height < age).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();
            return count;
        }

        private int ExecuteQueries2(UsersDbContext context)
        {
            var users0 = context.Users0.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();
            var users1 = context.Users1.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();
            var users2 = context.Users2.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();
            var users3 = context.Users3.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();
            var users4 = context.Users4.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();
            var users5 = context.Users5.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();
            var users6 = context.Users6.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();
            var users7 = context.Users7.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();
            var users8 = context.Users8.Where(u => u.Age == 20 && u.FirstName == "2" && u.CreateDate == DateTime.Now && u.Height < 200).ToArray();

            int count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            var date = DateTime.Now.AddDays(-1);
            var firstName = _rand.Next().ToString();
            var height = _rand.NextDouble();
            users0 = context.Users0.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();
            users1 = context.Users1.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();
            users2 = context.Users2.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();
            users3 = context.Users3.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();
            users4 = context.Users4.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();
            users5 = context.Users5.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();
            users6 = context.Users6.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();
            users7 = context.Users7.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();
            users8 = context.Users8.Where(u => u.CreateDate == date && u.Height > height && u.FirstName == firstName).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            date = DateTime.Now.AddHours(-25);
            var age = _rand.Next();
            users0 = context.Users0.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();
            users1 = context.Users1.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();
            users2 = context.Users2.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();
            users3 = context.Users3.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();
            users4 = context.Users4.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();
            users5 = context.Users5.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();
            users6 = context.Users6.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();
            users7 = context.Users7.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();
            users8 = context.Users8.Where(u => u.CreateDate == date && u.Age == age && (u.FirstName == "Bob" && u.LastName == "Smith")).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();

            date = DateTime.Now.AddHours(-25);
            var name = _rand.Next().ToString();
            age = _rand.Next();
            users0 = context.Users0.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();
            users1 = context.Users1.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();
            users2 = context.Users2.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();
            users3 = context.Users3.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();
            users4 = context.Users4.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();
            users5 = context.Users5.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();
            users6 = context.Users6.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();
            users7 = context.Users7.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();
            users8 = context.Users8.Where(u => u.LastName == name && u.Height < age || u.FirstName == name).ToArray();

            count = users0.Count() +
                users1.Count() +
                users2.Count() +
                users3.Count() +
                users4.Count() +
                users5.Count() +
                users6.Count() +
                users7.Count() +
                users8.Count();
            return count;
        }
    }    
}