// using System;
// class CheckDuplicate
// {
//     public static void Main()
//     {
//         Console.WriteLine("Enter the No. of Elements do you want to store in an array:");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine("Enter Element:");
//             int e = Convert.ToInt32(Console.ReadLine());
//             arr[i] = e;

//         }
//         bool isduplicate = false;
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = i + 1; j < n; j++)
//             {
//                 if (arr[i] == arr[j])
//                 {
//                     Console.WriteLine("DUPLICATES :"+arr[i] + " ");
//                     isduplicate = true;
//                 }
//             }
//         }
//         if (!isduplicate)
//         {
//             Console.WriteLine("NO DUPLICATES....");
//                     }
//     }
// }