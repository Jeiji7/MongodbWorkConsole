namespace TeamWorks
{
    public class Teams<Users>
    {
        public string Name { get; set; }
        public static int CountUsers { get; set; }
        public string TypeRoom { get; set; }
        public List<Users> TeamList;
        public Teams(string name, int countUsers, string typeRoom)
        {
            Name = name;
            CountUsers = countUsers;
            TypeRoom = typeRoom;
            TeamList = new List<Users>();
        }


        public void AddUser(Users user)
        {
            if (TeamList.Count < CountUsers)
            {
                TeamList.Add(user);
                Console.WriteLine($"Item '{user}' added to the list.");
            }
            else
            {
                Console.WriteLine($"Cannot add more items. Max count of {CountUsers} reached.");
            }
        }

    }
}
