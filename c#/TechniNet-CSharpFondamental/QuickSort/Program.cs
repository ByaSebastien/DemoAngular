using System.Collections.Concurrent;
using System.Runtime.InteropServices;

static void QuickSort(int[] array, int low, int high)
{
    if (low >= high)
    {
        return;
    }

    int pivo = Partition(array, low, high);
    QuickSort(array, low, pivo - 1);
    QuickSort(array, pivo + 1, high);
}

static int Partition(int[] array, int low, int high)
{
    int pivo = array[high];
    int i = (low - 1);

    for (int j = low; j < high; j++)
    {
        if (array[j] < pivo)
        {
            i++;
            swap(array, i, j);
        }
    }

    swap(array, i + 1, high);
    return (i + 1);
}

static void swap(int[] array, int i, int j)
{
    (array[i], array[j]) = (array[j], array[i]);
}

int[] a = {10,9,8,7,6,5,4,3,2,1,0};
QuickSort(a, 0, a.Length - 1);
Console.WriteLine("STOP");