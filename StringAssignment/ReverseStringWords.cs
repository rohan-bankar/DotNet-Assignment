public class ReverseStringWords
{
// Reverse the string word by word

    public static void ReverseWord(string str)
    {
        string[] str1 = str.Split(" ");
        for(int i=str1.Length-1; i>=0;i--)
        {
            Console.Write(str1[i]+" ");
        }
        Console.WriteLine();
    }
    // public static void Main(string[] args)
    // {
    //     string str = "Hello, My name is Rohan";
    //     ReverseWord(str);
    // }
}