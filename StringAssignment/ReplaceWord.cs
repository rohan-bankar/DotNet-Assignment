// Replace the particular word from the string by another string. 

public class ReplaceWord
{
    public static void Replace(string str)
    {
        Console.WriteLine("Enter old word");
        string oldword = Console.ReadLine();
        Console.WriteLine("Enter new word");
        string newword = Console.ReadLine();

        string[] str1 = str.Split(" ");
        for(int i=0; i<str1.Length;i++)
        {
            if(str1[i] == oldword)
            {
                str1[i] = newword;
            }
        }

        foreach(string s in str1)
        {
            Console.Write(s+" ");
        }
    }
    public static void Main(string[] args)
    {
        string str = "Hello my name is Rohan";
        Replace(str);
    }
}