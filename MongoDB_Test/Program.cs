using MongoDB_Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IMongoDBConfig config = new Config();

            MongoDataAccess dataAccess = new MongoDataAccess(config);

            User user1 = new User
            {
                Id = Guid.NewGuid(),
                Email = "email@email.com",
                Password = "sad43534r",
                CreationDate = DateTime.Now,
                Owner = false,
                State = true,
                Type = TypeEnum.Employee
            };

            User userToUpdate = new User
            {
                Id = new Guid("561fc9b6-74ab-d604-337f-3d83f8504e01"),
                Email = "dumy@yahoo.com",
                Password = "asdas8757as78fdsgh98hb8sad89a",
                CreationDate = DateTime.Now,
                Owner = false,
                State = true,
                Type = TypeEnum.None
            };

            await dataAccess.InsertAsync<User>("User", user1);

            List<User> users = await dataAccess.SelectAsync<User>("User");

            Display<User>(users);

            await dataAccess.DeleteAsync<User>("User", x => x.Id == user1.Id);

            List<User> users2 = await dataAccess.SelectAsync<User>("User");

            Console.WriteLine(users2.Count);

            await dataAccess.UpsertAsync<User>("User", x => x.Id == userToUpdate.Id, userToUpdate);

            List<User> userSingle = await dataAccess.SelectAsync<User>("User", x => x.Id == userToUpdate.Id);

            Console.WriteLine("updated user \n");
            Display<User>(userSingle);


            User user2 = new User
            {
                Id = Guid.NewGuid(),
                Email = "emai2l@email.com",
                Password = "sad43534r",
                CreationDate = DateTime.Now,
                Owner = false,
                State = false,
                Type = TypeEnum.Employee
            };
            User user3 = new User
            {
                Id = Guid.NewGuid(),
                Email = "email3@email.com",
                Password = "sad43534r",
                CreationDate = DateTime.Now,
                Owner = false,
                State = false,
                Type = TypeEnum.Employee
            };
            User user4 = new User
            {
                Id = Guid.NewGuid(),
                Email = "email4@email.com",
                Password = "sad43534r",
                CreationDate = DateTime.Now,
                Owner = false,
                State = false,
                Type = TypeEnum.Employee
            };


            await dataAccess.InsertManyAsync("User", new[] { user2, user3, user4 });

            List<User> newUsers = await dataAccess.SelectAsync<User>("User", x => x.Id == user2.Id || x.Id == user3.Id || x.Id == user4.Id);

            Console.WriteLine("list of users inserted \n\n");
            Display<User>(newUsers);

            await dataAccess.DeleteAsync<User>("User", x => x.Id == user2.Id || x.Id == user3.Id || x.Id == user4.Id);



            //pagination db.colection.find().skip(NUMBER_OF_ITEMS * (PAGE_NUMBER - 1)).limit(NUMBER_OF_ITEMS)

            //long items = await dataAccess.ContAsync<User>("User");
            long items = 2;
            Console.WriteLine(items);
            Console.WriteLine("pagination test, pag 1\n\n");
            List<User> userPage1 = await dataAccess.SelectAsync<User>("User", sortBy: x => x.Type, resultLimit: (int)items, resultsToSkip: (int)(items * (1 - 1)));
            Display<User>(userPage1);

            Console.WriteLine("pagination test, pag 2\n\n");
            List<User> userPage2 = await dataAccess.SelectAsync<User>("User", sortBy: x => x.Type, resultLimit: (int)items, resultsToSkip: (int)(items * (2 - 1)));
            Display<User>(userPage1);

            Console.WriteLine("pagination test, pag 3\n\n");
            List<User> userPage3 = await dataAccess.SelectAsync<User>("User", sortBy: x => x.Type, resultLimit: (int)items, resultsToSkip: (int)(items * (3 - 1)));
            Display<User>(userPage1);

            Console.WriteLine("pagination test, pag 4\n\n");
            List<User> userPage4 = await dataAccess.SelectAsync<User>("User", sortBy: x => x.Type, resultLimit: (int)items, resultsToSkip: (int)(items * (4 - 1)));
            Display<User>(userPage1);

            Console.WriteLine("ent Tests");
        }

        public static void Display<T>(object objs)
        {
            var t = typeof(T);
            var props = t.GetProperties();
            foreach (var obj in objs as IEnumerable<T>)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in props)
                {
                    sb.Append($"{item.Name}:{item.GetValue(obj, null)}; ");
                    sb.AppendLine();
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
