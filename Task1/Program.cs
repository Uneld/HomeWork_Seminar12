
int[] SingleLineInput()
{
    System.Console.WriteLine("Enter single line array with a \"space\"");
    return Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

int ReleaseArray(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.Clear();
int[] array = SingleLineInput();
System.Console.WriteLine($"Positive count = {ReleaseArray(array)}");