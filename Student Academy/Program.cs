
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
       
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
          
            string name = Console.ReadLine();
           
            double grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(name))
            {
                students[name] = new List<double>();
            }
            students[name].Add(grade);
        }

        foreach (var student in students.Where(x => x.Value.Average() >= 4.50).OrderByDescending(x => x.Value.Average()))
        {
            Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
        }
    