static int Solve()
{
    string filePath = "input/puzzle-input.txt";

    try
    {
        string[] lines = File.ReadAllLines(filePath);
        static int func (string line)
        {
            char firstNumeric = line.FirstOrDefault(char.IsDigit);
            char lastNumeric = line.LastOrDefault(char.IsDigit);
            string twoDigit = firstNumeric.ToString() + lastNumeric;
            return Convert.ToInt32(twoDigit);
        }
        return lines.Select(func).Sum();

        // second solution
        // return lines.Select((line) => Convert.ToInt32(line.FirstOrDefault(char.IsDigit).ToString() + line.LastOrDefault(char.IsDigit))).Sum();
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Error: {ex.Message}");
        return 0;
    }
}

int result = Solve();
System.Console.WriteLine(result);
