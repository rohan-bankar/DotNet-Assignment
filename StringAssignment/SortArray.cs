public class SortArray
{
//  Write a program to sort string arrays on the basis of length and if length is samethen lexicographically

    public static void Sort(string[] str)
    {
        for(int i=0;i<str.Length;i++)
        {
            for(int j=i+1;j<str.Length;j++)
            {
               if(str[i].Length > str[j].Length || (str[i].Length == str[j].Length && str[i].CompareTo(str[j])>0))
               {
                string temp = str[i];
                str[i] = str[j];
                str[j] = temp;
               }
            }
        }

        foreach(string s in str)
        {
            Console.Write(s+",");
        }
        
    }
    // public static void Main(string[] args)
    // {
    //     string[] str = {"apple", "banana", "pear", "kiwi", "plum", "grape", "fig"};
    //     Sort(str);
    // }
}