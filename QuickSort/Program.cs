internal class Program
{
    static int Partition(int[] arr , int Low ,int High)
    {
        int pivot = arr[Low];
        int i=Low; 
        int j=High;
        while (true)
        {
            while (arr[i] < pivot)
                i++;

            while (arr[j] > pivot)
                j--;

            if (i >= j)
                return j;

            Swap(ref arr[i], ref arr[j]);
        }
        Swap(ref arr[Low], ref arr[j]);
        return j;
    }
    static void QuickSort(int[] arr,int low ,int high)
    {
        if(low < high) { 
            int piv = Partition(arr, low, high);
            QuickSort(arr, low, piv);
            QuickSort(arr,piv+1, high);
        }
    }
    static void Swap(ref int x,ref int y)
    {
        int temp = x;
        x= y;
        y= temp;

    }

    static void printArray(int[] arr)
    {
        int size = arr.Length;
        Console.Write("["  );
        for (int i = 0; i < size; i++)
        {
            Console.Write($" {arr[i]} ");
            if (i<size-1)
                Console.Write( ", " );
        }
        Console.Write("]");
    }

    private static void Main(string[] args)
    {
        int[] arrayToBeSorted = { 20, 54, 77, 52, 10, 100, 90, 50, 60 };
        int size=arrayToBeSorted.Length;
        Console.WriteLine("The original Array :");
        printArray(arrayToBeSorted);
        QuickSort(arrayToBeSorted, 0, size-1);
        Console.WriteLine( "\nArray after being sorted :");
        printArray(arrayToBeSorted);

    }
}