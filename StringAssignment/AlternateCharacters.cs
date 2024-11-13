public class AlternateCharacters
{
    //  Show alternate characters from String from reverse.

    public static void Reverse(string str)
    {
        char[] ch = str.ToCharArray();

        for(int i=ch.Length-1;i>=0;i-=2)
        {
            Console.Write(ch[i]);
        }
    }
    // public static void Main(string[] args)
    // {
    //     string str = "Hello world";
    //     Reverse(str);
    // }
}