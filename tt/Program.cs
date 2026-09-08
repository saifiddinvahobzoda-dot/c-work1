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
//task1
// int a;
// int m=-9999;
// while (true)
// {
//     a=Convert.ToInt32(Console.ReadLine());
//     if (a == 0)
//     {
//         break;
//     }

//     if (a > m)
//     {
//         m=a;
//     }
// }
// System.Console.WriteLine(m);

//Task2
// System.Console.Write("Enter number: ");
// double a = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Enter stepen: ");
// int n = Convert.ToInt32(Console.ReadLine());


// double sum = 0;

// for (int i= 0; i <= n; i++)

// {

// sum += Math.Pow(a, i);

// }

// System.Console.WriteLine("Summa: " + sum);
//task1
// int a=Convert.ToInt32(Console.ReadLine());
// if (a < 100)
// {
//     int b=a+a*5/100;
//     System.Console.WriteLine(b);
// }
// else if (a>=100 && a <= 200)
// {
//     int b=a+a*7/100;
//     System.Console.WriteLine(b);
// }
// else
// {
//     int b=a+a*10/100;
//     System.Console.WriteLine(b);
// }




//task 2

// int a=Convert.ToInt32(Console.ReadLine());
// int[] ar = new int[a];
// int sum = 1;
// for (int i=0; i<a; i++)
// {
//     ar[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < a; i++)
// {
//     if(i == a - 1)
//     {
//         Console.Write($"{ar[i]} = ");
//     }
//     else if(ar[i] > 0)
//     {
//         Console.Write($"{ar[i]}*");
//     }
//     else if(ar[i] < 0)
//     {
//         Console.Write($"({ar[i]})*");
//     }
//     sum *= ar[i];
// }
// Console.Write(sum);
//task3
// int a=Convert.ToInt32(Console.ReadLine());
// int[] arr=new int[a];
// int m=0;
// for(int i=0; i<a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
    
// }
// for(int i=0; i<a; i++)
// {
//     if (arr[i] > arr[m])
//     {
//         m=i;
//     }
// }
// System.Console.WriteLine(m);
//task5
// int a=Convert.ToInt32(Console.ReadLine());
// int[] arr=new int[a];
// int m=0;
// for(int i=0; i<a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
    
// }
// for(int i=0; i<a; i++)
// {
//     if (arr[i] < arr[m])
//     {
//         m=i;
//     }
// }
// System.Console.WriteLine(m);
// task6
// int a=Convert.ToInt32(Console.ReadLine());
// int[] ar=new int[a];
// int s=0;
// for(int i=0; i<a; i++)
// {
//     ar[i]=Convert.ToInt32(Console.ReadLine());
// }
// for (int i=1; i<a-1; i++)
// {
//     if(ar[i]>ar[i+1] && ar[i] > ar[i - 1])
//     {
//         s++;
//     }
// }
// System.Console.WriteLine(s);
//task7
// int a=Convert.ToInt32(Console.ReadLine());
// int[] ar=new int[a];
// int b=0;
// int c=0;
// for(int i=0; i<a; i++)
// {
//     ar[i]=Convert.ToInt32(Console.ReadLine());
// }
// for (int i=1; i<a-1; i++)
// {
//     if(ar[i]>0 && ar[i+1]>0 || ar[i]<0 && ar[i+1]<0)
//     {
//         b=ar[i];
//         c=ar[i];
//     }
   
// }
// System.Console.WriteLine(b);
// System.Console.WriteLine(c);
//task8