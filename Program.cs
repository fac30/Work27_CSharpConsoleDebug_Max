string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {

        if (!int.TryParse(userValue, out valueEntered))
        {
            FormatException intFormatException = new("Invalid data. User input values must be valid integers.");
            throw intFormatException;
        }
        else if (int.Parse(userValue) == 0)
        {
            DivideByZeroException zeroFormatException = new("Invalid data. User input values must be non-zero values.");
            throw zeroFormatException;
        }
        else
        {
            valueEntered = int.Parse(userValue);
        }
    }
}