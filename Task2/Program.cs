int[] SingleLineInput()
{
    System.Console.WriteLine("Enter single line array with a \"space\"");
    return Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}


string ReleaseArray(int[] arr)
{
    if (arr.Length > 4)
    {
        return "Wrong enter";
    }

    double b1 = arr[0], k1 = arr[1], b2 = arr[2], k2 = arr[3];
    double diffK = k1 - k2, diffB = b1 - b2;
    if (diffK == 0)
    {
        return "Lines are not cross";
    }

    double x = Math.Round(-diffB / diffK, 2);
    double y = Math.Round(k2 * x + b2, 2);
    return $"Intersection point ({x}; {y})";
}


//-1 2 1 -3
//0 1 -2 3
//3 2 5 2
//2 5 4 9
System.Console.Clear();
System.Console.WriteLine("Enter b1, k1, b2, k2");
int[] array = SingleLineInput();
System.Console.WriteLine(ReleaseArray(array));