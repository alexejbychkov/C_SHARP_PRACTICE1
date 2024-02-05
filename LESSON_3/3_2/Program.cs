int[] array = {2,3,5,-10,-2,-5,10,8,-1,-5};

for (int i = 0; i < array.Length; i++)
{
    array[i]=array[i]*-1;
    Console.Write($"{array[i]} ");
}