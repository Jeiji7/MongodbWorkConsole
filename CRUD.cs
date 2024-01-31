using MongoDB.Bson;
using MongoDB.Driver;
using System.Xml.Linq;
using System;

namespace TeamWorks
{
    public class CRUD
    {
        public static void CreateUser(Users user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users2024");
            var collection = database.GetCollection<Users>("UserData");
            collection.InsertOne(user);
        }
        public static void CreateTestTeam(Teams<Users> team)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users2024");
            var collection = database.GetCollection<Teams<Users>>("UserCollection");
            collection.InsertOne(team);
        }
        public static void ShowInfoAllUsers(string keyword = null)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users2024");
            var collection = database.GetCollection<Users>("UserData");

            // Фильтр по имени, если передано ключевое слово
            var filter = Builders<Users>.Filter.Empty;
            if (!string.IsNullOrEmpty(keyword))
            {
                filter = Builders<Users>.Filter.Where(user => user.Name.Contains(keyword));
            }

            var result = collection.Find(filter).ToList();

            if (result.Any())
            {
                Console.WriteLine("Информация о найденных пользователях:");

                foreach (var user in result)
                {
                    Console.WriteLine($"Имя: {user.Name}, Возраст: {user.Age}, Email: {user.Email}");
                }
            }
            else
            {
                Console.WriteLine("Пользовател(ь/и) не найдены.");
            }
        }

        public static void DeleteUser(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users2024");
            var collection = database.GetCollection<Users>("UserData");

            var filter = Builders<Users>.Filter.Eq("Name", name);
            var result = collection.DeleteOne(filter);

            if (result.DeletedCount > 0)
            {
                Console.WriteLine($"Удален пользователь с именем: {name}");
            }
            else
            {
                Console.WriteLine($"Пользователь с именем {name} не найден.");
            }
        }
        public static void DeleteAllUsers()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users2024");
            var collection = database.GetCollection<Users>("UserData");

            var result = collection.DeleteMany(Builders<Users>.Filter.Empty);

            Console.WriteLine($"Удалено {result.DeletedCount} пользователей.");
        }
    }
}
