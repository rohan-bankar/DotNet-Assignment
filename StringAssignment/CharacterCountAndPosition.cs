public class CharacterCountAndPosition
{
    // Check occurrences of particular  characters, how many times it’s there and which diff positions.

    public static void Check(string str,char ch)
    {
        char[] ch1 = str.ToCharArray();
        int count = 0;
        for(int i=0;i<ch1.Length;i++)
        {
            if(ch1[i] == ch)
            {
                count++;
            Console.WriteLine($"Index No = {i}, Count = {count}");
            }
        }
    }
    // public static void Main(string[] args)
    // {
    //  string str = "hello world";   
    //  char ch = 'l';
    //  Check(str,ch);
    // }
}