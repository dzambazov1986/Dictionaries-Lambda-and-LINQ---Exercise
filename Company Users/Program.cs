using System;
using System.Collections.Generic;
 var companies = new Dictionary<string, HashSet<string>>();
        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            var parts = command.Split(" -> ");
            var companyName = parts[0];
            var employeeId = parts[1];

            if (!companies.ContainsKey(companyName))
            {
                companies[companyName] = new HashSet<string>();
            }

            companies[companyName].Add(employeeId);
        }

        foreach (var company in companies)
        {
            Console.WriteLine(company.Key);
            foreach (var id in company.Value)
            {
                Console.WriteLine("-- {0}", id);
            }
        }