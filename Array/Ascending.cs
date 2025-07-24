// class Ascending
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
        
//         for (int i = 0; i < n-1; i++)
//         {
//               int index = i;
//             for (int j = i + 1; j < n; j++)
//             {
//                 if (arr[j] > arr[index])
//                 {
//                     index = j;
//                 }
//             }
//                 int l = arr[index];
//                 arr[index] = arr[i];
//                 arr[i] = l;
            
//         }
//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine(arr[i]);
//         }
//     }
// }