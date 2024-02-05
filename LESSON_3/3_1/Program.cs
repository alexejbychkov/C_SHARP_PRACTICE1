int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int a = int.Parse(Console.ReadLine()!);
bool b = false;
for (int i = 0; i < arr.Length; a++)
{
    if (a == arr[i])
    {
        b = true;
    }
}
if (b)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
