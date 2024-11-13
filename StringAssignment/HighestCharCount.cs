public class HighestCharCount
{
    // Write a C# program to find the highest frequency character in a string.

    public static void Count(string str)
    {
        char[] ch = str.ToCharArray();
        int max = 0;
        char ch1 = ' ';
        for(int i=0;i<ch.Length;i++)
        {
            int count = 0;
            for(int j=i;j<ch.Length;j++)
            {
                if(ch[i] == ch[j])
                {
                    count++;
                }
            }     
            if(max < count)
            {
                max = count;
                ch1 = ch[i];
            }
        }
        Console.WriteLine($"{ch1} = {max}");
    }
    // public static void Main(string[] args)
    // {
    //     string str = "Hello worldooo";
    //     Count(str);
    // }
}