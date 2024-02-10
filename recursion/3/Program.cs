int[] arr = { -1, 1, 9, 6, 0, -4, -8, 5, 10 };
void ShowReversedArray (int[] array, int i = 0)
        {
            if (i != array.Length)
            {
            ShowReversedArray(array, i+1);
            Console.Write(array[i] + " ");
            }
        }
ShowReversedArray (arr);