public class CountEachChar
{
    public static void Count(string str)
    {
        char[] ch = str.ToLower().ToCharArray();

        for(int i=0;i<ch.Length;i++)
        {
           if(ch[i] == ' ')
           {
            continue;
           }

           bool repetedword = false;

           for(int j=0;j<i;j++)
           {
            if(ch[i] == ch[j])
            {
                repetedword = true;
                break;
            }
           }

           if(repetedword)
           {
            continue;
           }

           int count = 0;
           for(int k=0;k<ch.Length;k++)
           {
            if(ch[i] == ch[k])
            {
                count++;
            }
           }
           Console.WriteLine($"{ch[i]} = {count}");
        }
    }
    // public static void Main(string[] args)
    // {
    //     string str = "Hi my name is Rohan";
    //     Count(str);
    // }
}