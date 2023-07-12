namespace swapInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length:-");
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"enter the num {i+1}");
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine( "enter the first index" );
            int index1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second index");
            int index2=int.Parse(Console.ReadLine());
           Swap(arr, index1, index2);   
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Swap(int[] Arr , int Index1 , int Index2)
        {
            int temp = Arr[Index1];
            Arr[Index1] = Arr[Index2];
            Arr[Index2] = temp;
        }

    }
}