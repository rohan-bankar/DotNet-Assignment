public class SumOfRowAndCol
{
    public static void Main(string[] args)
    {
        int[,] arr1 = new int[2,3]{
            {1,2,5},
            {3,4,6}
        };
        
        for(int i=0;i<2;i++)
        {
        int sumofrow = 0;
            for(int j=0;j<3;j++)
            {
                sumofrow += arr1[i,j];
            }
            Console.WriteLine($"Row {i+1} sum = {sumofrow}");
        }

         for(int i=0;i<2;i++)
        {
            int sumofcol = 0;
            for(int j=0;j<3;j++)
            {
                sumofcol += arr1[j,i];
            }
            Console.WriteLine($"Col {i+1} sum = {sumofcol}");
        }
    }
}