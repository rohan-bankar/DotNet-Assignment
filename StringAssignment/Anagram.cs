public class Anagram
{
    public static void Check(string str1,string str2)
    {
        char[] ch1 = str1.ToCharArray();
        char[] ch2 = str2.ToCharArray();
        int count = 0;
            
            for(int i=0;i<ch1.Length;i++)
            {
                for(int j=0;j<ch2.Length;j++)
                {
                    if(ch1[i] == ch2[j])
                    {
                        count++;
                    }
                }
            }
    
        if(ch1.Length == count)
        {
            Console.WriteLine("String is Anagram");
        }
        else
        {
            Console.WriteLine("String is not Anagram");
        }
    }
    // public static void Main(string[] args)
    // {
    //     string str1 = "gum";
    //     string str2 = "mug";

    //     Check(str1,str2);
    // }
}