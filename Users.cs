using MongoDB.Driver;
using MongoDB.Bson;
namespace TeamWorks
{
    public class Users
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Users (string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
        public ObjectId _id;
    }
}
