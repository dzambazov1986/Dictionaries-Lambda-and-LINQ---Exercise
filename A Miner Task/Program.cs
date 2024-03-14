using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, long> resources = new Dictionary<string, long>();
        string input;
        int line = 1;
        string lastResource = "";

        while ((input = Console.ReadLine()) != "stop")
        {
            if (line % 2 != 0)
            {
                if (!resources.ContainsKey(input))
                {
                    resources[input] = 0;
                }
                lastResource = input;
            }
            else
            {
                long quantity = long.Parse(input);
                resources[lastResource] += quantity;
            }
            line++;
        }

        foreach (var resource in resources)
        {
            Console.WriteLine($"{resource.Key} -> {resource.Value}");
        }
    }
}
