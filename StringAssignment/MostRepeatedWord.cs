// WAP to find the most repeated word in a string
public class MostRepeatedWord
{
    public static void FindCount(string str)
    {
        string[] str1 = str.Split(" ");
        int max = 0;
        string word = "";
        for(int i=0; i<str1.Length;i++)
        {
            int count = 0;
            for(int j=i;j<str1.Length;j++)
            {
                if(str1[j].Equals(str1[i]))
                {
                    count++;
                }
            }
            if(max < count)
            {
                max = count;
                word = str1[i];
            }
        }
        Console.WriteLine($"{word} = {max}");
    }
    // public static void Main(string[] args)
    // {
    //     string str = "The big brown dog and the small brown dog ran across the big green field and the small green field.";
    //     FindCount(str);
    // }
}