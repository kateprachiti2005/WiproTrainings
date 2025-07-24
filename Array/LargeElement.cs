// using System;
// class LargeElement
// {
//     public static void Main()
//     {
//         int max = 0;
//         Console.WriteLine("Enter the No. of Elements do you want to store in an array:");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine("Enter Element:");
//             int e = Convert.ToInt32(Console.ReadLine());
//             arr[i] = e;
//         }
//         for (int i = 0; i < n; i++)
//         {
//             if (arr[i] > max)
//             {
//                 max = arr[i];
//             }
//         }
//         Console.WriteLine("Largest Number is:" + max);

//     }
// }