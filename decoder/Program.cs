// See https://aka.ms/new-console-template for more information

//pyramid(10, null);
//Console.WriteLine(decode("file1.txt"));

Console.WriteLine(decode("file2.txt"));

static string decode(string message_file)
{
    string message = "";
    List<string> lines = File.ReadAllLines(message_file).ToList();
    SortedDictionary<int, string> decode = new SortedDictionary<int, string>();
    lines.ForEach(line => {
        decode.Add(int.Parse(line.Split(" ")[0]), line.Split(" ")[1]);
    });

    return pyramid(decode);
}

static string pyramid(SortedDictionary<int, string> dict)
{
    string str = "";
    int start = 1;
    for (int i = 1; start <= dict.Keys.Count(); i++)
    {
        for (int j = 1; j <= i; j++)
        {
            if (j == i)
            {
                str += $" {dict[start]}";
            }
            start++;
        }
    }

    return str.TrimStart();
}

/*

1
2 3
4 5 6
7 8 9 10
11 12 13 14 15
16 17 18 19 20 21

*/