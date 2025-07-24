// using System;
// class ReverseArray
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
//         int left = 0, right = n - 1,temp=0;
//         for (int i = 0; i < n/2; i++)
//         {
//              temp = arr[left];
//             arr[left] = arr[right];
//             arr[right] = temp;
//             left++;
//             right--;
//         }
//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine("Enter Element:"+arr[i]);
           

//         }

//     }
// }