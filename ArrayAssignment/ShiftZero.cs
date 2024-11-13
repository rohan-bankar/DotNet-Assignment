public class ShiftZero
{
    // 8. Shift all zeros in the beginning of array/ Shift zeros at end
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,0,0,5,2,1};

        // shift last
        int[] arr1 = new int[arr.Length];
        int j = 0;
        for(int i=0;i<arr.Length;i++)
        {
           if(arr[i] != 0)
           {
            arr1[j++] = arr[i];
           }
        }

        while(j<arr.Length)
        {
            arr1[j++] = 0;
        }
        

        // shift first
        int end = -1;
        for(int i=arr.Length-1;i>=0;i--)
        {
            if(arr[i] == 0)
            {
                end = i;
                Console.WriteLine($"end index = {end}");
                break;
            }
        }

        for(int i=end-1;i>=0;i--)
        {
            if(arr[i] != 0)
            {
                int temp = arr[i];
                arr[i] = arr[end];
                arr[end] = temp;
                end--;
            }
        }
       
        Console.WriteLine("------Move zero last------");
        foreach(int i in arr1)
        {
            Console.WriteLine(i);
        }

         Console.WriteLine("------Move zero front------");
        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}