public class FindCommon
{
    // Take two string arrays and find the common elements between them

    public static void CommonWords(string str1,string str2)
    {
        string[] str1arr = str1.Split(" "); 
        string[] str2arr = str2.Split(" ");

        for(int i=0;i<str1arr.Length;i++)
        {
            for(int j=0;j<str2arr.Length;j++)
            {
                if(str1arr[i].Equals(str2arr[j]))
                {
                    Console.WriteLine($"{str1arr[i]}");
                }
            }
        } 
    }

    // public static void Main(string[] args)
    // {
    //     string str1 = "Hello welcome to pune";
    //     string str2 = "Hello nice to meet you";
    //     CommonWords(str1,str2);
    // }
}