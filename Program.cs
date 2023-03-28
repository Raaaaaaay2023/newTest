string[] inputStrings = ReadInputStrings();
string[] outputStrings = FilterStrings(inputStrings);
PrintStrings(outputStrings);
static string[] ReadInputStrings()
{
    Console.WriteLine("Enter a string of words separated by spaces:");
    string input = Console.ReadLine();
    return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
}

static string[] FilterStrings(string[] inputStrings)
{
    int count = 0;
    for (int i = 0; i < inputStrings.Length; i++)
    {
        if (inputStrings[i].Length <= 3)
        {
            count++;
        }
    }

    string[] outputStrings = new string[count];
    count = 0;
    for (int i = 0; i < inputStrings.Length; i++)
    {
        if (inputStrings[i].Length <= 3)
        {
            outputStrings[count] = inputStrings[i];
            count++;
        }
    }

    return outputStrings;
}


static void PrintStrings(string[] outputStrings)
{
    Console.WriteLine("Short words：");
    for (int i = 0; i < outputStrings.Length; i++)
    {
        Console.WriteLine(outputStrings[i]);
    }
}