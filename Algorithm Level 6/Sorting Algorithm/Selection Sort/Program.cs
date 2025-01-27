namespace Selection_Sort
{
    public class Program
    {
        static void SelectionSortAsc(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[minIndex])
                        minIndex = j;

                // Swap the found minimum element with the first element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void SelectionSortDescinding(int[]arr)
        {
            int n= arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                int MaxIndedx= i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[MaxIndedx])
                        MaxIndedx =j;

                    int Temp= arr[MaxIndedx];
                    arr[MaxIndedx ]= arr[i];
                    arr[i]= Temp;

                }
            }
        }
        public static void PrintArray(int[]arr)
        {
            foreach(int i in arr)
                Console.Write(i+" ");
        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            PrintArray(arr);
            Console.WriteLine("\n==================================");
            Console.WriteLine("After Sorting Ascending ");
            SelectionSortAsc(arr);
            PrintArray(arr);
            Console.WriteLine("\n===================================");
            Console.WriteLine("After Sorting Descinding");
            SelectionSortDescinding(arr);
            PrintArray(arr);
            Console.ReadKey();
        }
    }
}
