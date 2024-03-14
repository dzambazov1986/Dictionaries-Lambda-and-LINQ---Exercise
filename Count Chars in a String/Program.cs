 string input = Console.ReadLine();

        Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (c != ' ')
            {
                if (charOccurrences.ContainsKey(c))
                {
                    charOccurrences[c]++;
                }
                else
                {
                    charOccurrences[c] = 1;
                }
            }
        }

        foreach (KeyValuePair<char, int> pair in charOccurrences)
        {
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    