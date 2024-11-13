public class ToggleFirstChar
{

    public static void Toggle(string str)
    {
        string[] str1 = str.Split(" ");
        for (int i = 0;i<str1.Length;i++)
        {
            char[] ch = str1[i].ToCharArray();
            for(int j=0;j<ch.Length;j++)
            {
                 if(ch[0] >= 97 && ch[0] <= 122)
                {
                    ch[j]-=(char)32;
                }
                    Console.Write(ch[j]);
            }
                Console.Write(" ");
        }
    }
    // public static void Main(string[] args)
    // {
    //     string str = "hello welcome to pune, my name is rohan";
    //     Toggle(str);
    // }
}