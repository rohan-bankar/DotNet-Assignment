public class CountCharacter
{
    // Calculate no of vowels, consonants , digits and special symbol from given String

    public static void Count(string str)
    {
        char[] ch = str.ToCharArray();
        int vowelscount=0;
        int consonantscount=0;
        int digitcount = 0;
        int symbolcount = 0;

        for(int i=0; i<ch.Length;i++)
        {
            if(ch[i] >= '0' && ch[i] <= '9')
            {
                digitcount++;
            }
            else if(ch[i] == 'a' || ch[i] == 'A' || ch[i] == 'e' || ch[i] == 'E' || ch[i] == 'i' || ch[i] == 'I' || ch[i] == 'o' || ch[i] == 'O' || ch[i] == 'u' || ch[i] == 'U' )
            {
                vowelscount++;
            }
            else if(ch[i] == '@' || ch[i] == '$' || ch[i] == '*' || ch[i] == '#' || ch[i] == '!')
            {
                symbolcount++;
            }
            else
            {
                consonantscount++;
            }
            Console.WriteLine(ch[i]);
        }
        Console.WriteLine($"Vowels Count = {vowelscount}");
        Console.WriteLine($"Digits Count = {digitcount}");
        Console.WriteLine($"Consonants Count = {consonantscount}");
        Console.WriteLine($"Symbols Count = {symbolcount}");
    }
    
    // public static void Main(string[] args)
    // {
    //     string str = "Rohan@123";
    //     Count(str);
    // }
}