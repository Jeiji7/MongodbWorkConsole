using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
using TeamWorks;

//CRUD.CreateUser(new Users("Vovan", 20, "gg@email.com"));
//CRUD.CreateUser(new Users("Semen", 22, "hhh@gmail.com"));
//CRUD.CreateUser(new Users("Feda", 16, "ghg@com"));
//CRUD.CreateUser(new Users("Petr", 32, "hgfdgh@gmail.com"));
//CRUD.CreateUser(new Users("Alex", 25, "korbor@gmail.com"));

class Program
{

    static void Main(string[] args)
    {
        //CRUD.CreateUser(new Users("Vovan", 20, "gg@email.com"));
        //CRUD.CreateUser(new Users("Semen", 22, "hhh@gmail.com"));
        //CRUD.CreateUser(new Users("Feda", 16, "ghg@com"));
        //CRUD.CreateUser(new Users("Petr", 32, "hgfdgh@gmail.com"));
        //CRUD.CreateUser(new Users("Alex", 25, "korbor@gmail.com"));
        //CRUD.ShowInfoAllUsers("Vovan");
        //CRUD.DeleteUser("Vovan");
        CRUD.ShowInfoAllUsers();
        CRUD.DeleteAllUsers();
        CRUD.ShowInfoAllUsers();
    }
}

// Команду создаём с типочками
//Teams<Users> teams = new Teams<Users>("Team Spirit5", 3, "CS");
//teams.AddUser(new Users("Vovan", 20, "gg@email.com"));
//teams.AddUser(new Users("Semen", 22, "hhh@gmail.com"));
//teams.AddUser(new Users("Petr", 32, "hgfdgh@gmail.com"));
//teams.AddUser(new Users("Grud", 24, "tank44h@gmail.com"));
//teams.AddUser(new Users("Alex", 25, "korbor@gmail.com"));
//Console.WriteLine("Успешно создали комнату с игроками");
//CRUD.CreateTestTeam(teams);



