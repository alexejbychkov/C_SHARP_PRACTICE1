void ShowNumbers(int m, int n)
 {
if (m != n+1)
{
Console.Write($"{m} ");
ShowNumbers (m+1, n);
}  
 }
ShowNumbers(1, 15);