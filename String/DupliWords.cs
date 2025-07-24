using System;
class DupliChar
{
    public static void Main()
    {
        Console.WriteLine("ENTER STRING:");
        string s = Console.ReadLine();
        string[] words = s.Split();
        Console.WriteLine("Duplicates:");
        for (int i = 0; i < words.Length; i++)
        {



            int count = 0;
            for (int j = 0; j < words.Length; j++)
            {
                if (words[i] == words[j]) count++;
            }

         if (count > 1 ) 
            {
                Console.WriteLine(words[i]+" is duplicate");
            }
        }
        
        
    }
}