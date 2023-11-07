namespace P04.SoftUniParking
{
    class User
    {
        public User(string username, string licensePlateNumber)
        {
            Username = username;
            LicensePlateNumber = licensePlateNumber;
        }

        public string Username { get; set; }
        public string LicensePlateNumber { get; set; }

        public override string ToString()
        {
            return $"{Username} => {LicensePlateNumber}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> usersMap = new Dictionary<string, User>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string command = input[0];
                string name = input[1];

                if (command == "register")
                {
                    string plateNumber = input[2];

                    User user = new User(name, plateNumber);

                    if (usersMap.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else
                    {
                        usersMap.Add(name, user);
                        Console.WriteLine($"{user.Username} registered {user.LicensePlateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!usersMap.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        usersMap.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (KeyValuePair<string, User> kvp in usersMap)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}