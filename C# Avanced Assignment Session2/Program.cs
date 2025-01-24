
using System.Collections;
using System.Collections.Generic;

namespace C__Avanced_Assignment_Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1

            //string[] input = Console.ReadLine().Split();
            //int n = int.Parse(input[0]); 
            //int s = int.Parse(input[1]);

            //string[] arrayInput = Console.ReadLine().Split();
            //List<int> numbers = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    numbers.Add(int.Parse(arrayInput[i]));
            //}

            //for (int i = 0; i < s; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int count = 0; 

            //    foreach (int num in numbers)

            //        if (num > x)
            //            count++;

            //    Console.WriteLine(count);
            //}
            #endregion

            #region Q 2

            //int NUM = int.Parse(Console.ReadLine());
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //bool isPalindrome = true;
            //for (int i = 0; i < NUM / 2; i++)

            //    if (arr[i] != arr[NUM - 1 - i])

            //        isPalindrome = false;


            //Console.WriteLine(isPalindrome ? "Y" : "N");
            #endregion

            #region Q 3

            //Queue<int> queue = new Queue<int>();
            //Console.WriteLine(" Number of Elements : ");
            //int count = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the elements: ");
            //for (int i = 0; i < count; i++)
            //{
            //    queue.Enqueue(int.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("\nQueue before reverse : ");
            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //Stack<int> stack = new Stack<int>();

            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}

            //Console.WriteLine("\nQueue after reverse : ");
            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            #endregion

            #region Q 4 [solve in the end "Not Solved Yet"]


            #endregion

            #region Q 5

            //Console.WriteLine(" The Elements : ");
            //string input = Console.ReadLine();
            //string[] inputArray = input.Split(' ');  //  ملاحظة ليا : بقسم الحاجة بناءا على مسافة // 

            //List<string> List1 = new List<string>();

            //foreach (string item in inputArray)
            //{
            //    if (!List1.Contains(item)) 
            //        List1.Add(item);

            //}

            //Console.WriteLine("After Removing : ");
            //foreach (string item in List1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q 6

            //Console.WriteLine("The Elements :");
            //string input = Console.ReadLine();
            //string[] inputArray = input.Split(' '); 

            //List<int> numbers = new List<int>();
            //foreach (string item in inputArray)
            //{
            //    numbers.Add(int.Parse(item)); 
            //}

            //numbers.RemoveAll(n => n % 2 != 0);  

            //// Display the result
            //Console.WriteLine("After Removing : ");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q 7

            #endregion

        }

    } 

}
