// using System;
// class DupliChar
// {
//     public static void Main()
//     {
//         Console.WriteLine("ENTER STRING:");
//         string s = Console.ReadLine();
//          Console.WriteLine("Duplicates:");
//         for (int i = 0; i < s.Length; i++)
//         {
//             char ch = s[i];
//             if (ch == ' ') continue;  // skip spaces

//             int count = 0;
//             for (int j = 0; j < s.Length; j++)
//             {
//                 if (s[j] == ch) count++;
//             }

//             if (count > 1 && s.IndexOf(ch) == i) 
//             {
//                 Console.WriteLine($"'{ch}' appears {count} times");
//             }
//         }
        
//     }
// }