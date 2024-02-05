{
    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int[] result = new int[arr.Length / 2 + arr.Length % 2];
    int j = 0;
    for (int i = 0; i < arr.Length - 1; i += 2)
    {
        result[i] = arr[i] * arr[arr.Length - i - 1];
        j++;
    }
    if (arr.Length % 2 != 0)
    {
        result[j] = arr[arr.Length - 1];
    }
    Console.WriteLine(string.Join(" ", result));

}