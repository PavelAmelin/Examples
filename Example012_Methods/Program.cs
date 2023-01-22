void Sort(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        int min_pos = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[min_pos])
            min_pos = j;
        }
        int temp = array[i];
        array[i] = array[min_pos];
        array[min_pos] = temp;
        Console.WriteLine($"{array[i]}");
    }
}

int[] arr = {5, 3, 4, 53, 2, 2, 3, 4, 42, 1345, 66};
Sort(arr);