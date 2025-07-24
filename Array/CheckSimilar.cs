// using System;
// class CheckSimilar
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
//         Console.WriteLine("Enter the No. of Elements do you want to store in an array:");
//         int n1 = Convert.ToInt32(Console.ReadLine());
//         int[] arr1 = new int[n1];
//         for (int i = 0; i < n1; i++)
//         {
//             Console.WriteLine("Enter Element:");
//             int e = Convert.ToInt32(Console.ReadLine());
//             arr1[i] = e;

//         }
//         bool y = true;
//         for (int i = 0; i < n; i++)
//         {
//             if (arr[i] != arr1[i])
//             {
//                 y = false;
//             }
            
//         }
//         if (y)
//         {
//             Console.WriteLine("Arrays are same...");
//         }
//         else
//         {
//              Console.WriteLine("Arrays are not same..."); 
//         }
//     }
// }