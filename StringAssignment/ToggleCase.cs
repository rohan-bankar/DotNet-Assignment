public class ToggleCase
{
    public static void Toggle(string str)
    {
        char[] ch = str.ToCharArray();
        
        for(int i=0; i < ch.Length;i++)
        {
            if(ch[i] >= 65 && ch[i] <= 90)
            {
                ch[i]+=(char)32;
            }
            else
            {
                ch[i]-=(char)32;
            }
        }

        for(int i=0;i<ch.Length;i++)
        {
            Console.Write(ch[i]);
        }
        Console.WriteLine();
    }

    // public static void Main(string[] args)
    // {
    //     string str = "HELLO WORLD";
    //     Toggle(str);
    // }
}