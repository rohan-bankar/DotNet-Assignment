public class RemoveSpaces
{
//  Write a C# program to remove all extra blank spaces from a given string.
    public static void RemoveSpace(string str)
    {
        char[] ch = str.ToCharArray();
        for(int i=0; i<ch.Length;i++)
        {
            if(ch[i] == ' ')
            {
                continue;
            }
            Console.Write(ch[i]);
        }
    }
    // public static void Main(string[] args)
    // {
    //     string str = "   Hello     ";
    //     RemoveSpace(str);
    // }
}