//  Check whether String is palindrome.
public class palindrome
{

    public static void IsPalindrome(string str)
    {
       char[] ch = str.ToCharArray();
       bool flag = true; 
       for(int i=0; i<ch.Length;i++)
       {
            if(ch[i] != ch[ch.Length-1-i])
            {
                flag = false;
                break;
            }
       }

       if(flag)
       {
        Console.WriteLine("string is palindrome");
       }
       else
       {
        Console.WriteLine("string is not  palindrome");
       }
    } 
    // public static void Main(string[] args)
    // {
    //     string str = "maam";
    //     IsPalindrome(str);
    // }
}