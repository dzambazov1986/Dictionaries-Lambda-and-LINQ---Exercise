Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();

            string username = command[1];

            if (command[0] == "register")
            {
                string licensePlateNumber = command[2];

                if (parkingDatabase.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {parkingDatabase[username]}");
                }
                else
                {
                    parkingDatabase[username] = licensePlateNumber;
                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                }
            }
            else if (command[0] == "unregister")
            {
                if (!parkingDatabase.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    parkingDatabase.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }
        }

        foreach (var user in parkingDatabase)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    