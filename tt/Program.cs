// int max=int.MinValue;
// int a;
// while (true)
// {
//     a=Convert.ToInt32(Console.ReadLine());
//     if (a==0)
//     {
//       break;
//     }
//     if (a > max)
//     {
//         max = a;
//     }
// }
// System.Console.WriteLine(max);


// // task2
// double adad=Convert.ToDouble(Console.ReadLine());
// double dar=Convert.ToDouble(Console.ReadLine());
// double sum=0;
// for(int i=0; i<=dar; i++)
// {
//     sum+=Math.Pow(adad, i);
// }
// System.Console.WriteLine("Summa "+sum);

// //  Task 3

// int a;

// int sum=0;
// int zero=0;
// while (true)
// {
//     a=Convert.ToInt32(Console.ReadLine());
   
//     if(a==0 )
//     {
//        zero++;
//         if (zero == 2)
//         {
//             break;
//         }
//     }
//     if (a>0)
//     {
//      sum+=a;
//      zero=0;
//     }
  

// }
// Console.WriteLine(sum);


// //task 4
//   int a = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[a];

//         for (int i = 0; i < a; i++)
//         {
//             arr[i] = Convert.ToInt32(Console.Read());
//         }

//         for (int i = 0; i < a - 1; i++)
//         {
//             arr[i] = Convert.ToInt32(Console.Read());
//             if ((arr[i] > 0 && arr[i + 1] > 0) || (arr[i] < 0 && arr[i + 1] < 0))
//             {
//                 Console.WriteLine("YES");
//                 break;
//             }
//             else
// {
//     Console.WriteLine("NO");
//     break;
// }
//         }

        
//     //Task 5
// int n = Convert.ToInt32(Console.ReadLine());
//         string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
//         int[] a = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             a[i] = Convert.ToInt32(input[i]);
//         }
//         for (int i = 0; i < n; i++)
//         {
//             int count = 0;
//             for (int j = 0; j < n; j++)
//             {
//                 if (a[i] == a[j])
//                 {
//                     count++;
//                 }
//             }
//             if (count > 1)
//             {
//                 Console.Write(a[i] + " ");
//             }
//         }

// Task 6
int min = int.MaxValue;
int a;
a=Convert.ToInt32(Console.Read());
for (int i=1; i<=a; i++)
{
    int s=Convert.ToInt32(Console.Read());
    if (s < min)
    {
        min=s;
    }
}
System.Console.WriteLine(min);