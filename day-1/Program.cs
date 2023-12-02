static int Solve()
{
    string filePath = "input/puzzle-input.txt";

    try
    {
        string[] lines = File.ReadAllLines(filePath);

        int sum = 0;
        foreach (string line in lines)
        {
            char firstNumeric = line.FirstOrDefault(char.IsDigit);
            char lastNumeric = line.LastOrDefault(char.IsDigit);
            string twoDigit = firstNumeric.ToString() + lastNumeric;
            sum += Convert.ToInt32(twoDigit);
        }
        return sum;
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Error: {ex.Message}");
        return 0;
    }
}

int result = Solve();
System.Console.WriteLine(result);
