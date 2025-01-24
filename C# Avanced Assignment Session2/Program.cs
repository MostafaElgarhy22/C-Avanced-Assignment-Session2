
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

            #region Q 4 
            //string input = "()[{}]";

            //Stack<char> stack = new Stack<char>();
            //bool isBalanced = true;

            //foreach (char c in input)
            //{
            //    if (c == '(' || c == '{' || c == '[')
            //    {
            //        stack.Push(c);
            //    }
            //    else if (c == ')' || c == '}' || c == ']')
            //    {
            //        if (stack.Count == 0)
            //        {
            //            isBalanced = false;
            //            break;
            //        }

            //        char open = stack.Pop();
            //        if ((open == '(' && c != ')') || (open == '{' && c != '}') || (open == '[' && c != ']'))
            //        {
            //            isBalanced = false;
            //            break;
            //        }
            //    }
            //}

            //if (isBalanced)
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}

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

            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);       
            //queue.Enqueue("Apple"); 
            //queue.Enqueue(5.28);   

            //Console.WriteLine("Queue elements : ");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q 8

            //Stack<int> stack = new Stack<int>();

            //stack.Push(5);
            //stack.Push(10);
            //stack.Push(15);
            //stack.Push(20);
            //stack.Push(25);

            //Console.WriteLine("Enter the target integer :");
            //int target = int.Parse(Console.ReadLine());

            //int count = 0;
            //bool found = false;


            //Stack<int> stack2 = new Stack<int>(stack);
            //while (stack2.Count > 0)
            //{
            //    count++;
            //    int item = stack2.Pop(); 
            //    if (item == target)
            //    {
            //        found = true;
            //        Console.WriteLine($"Target was found successfully and the count = {count}");
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("Target was not found");
            //}
            #endregion

            #region Q 9

            //    List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            //    List<int> list2 = new List<int> { 10, 8, 5 };

            //    List<int> result = FindElement(list1, list2);

            //    Console.WriteLine("Common of the two arrays:");
            //    foreach (int num in result)
            //    {
            //        Console.Write(num + " ");
            //    }
            //    Console.WriteLine();
            //}

            //static List<int> FindElement(List<int> list1, List<int> list2)
            //{
            //    List<int> result = new List<int>();

            //    foreach (int num in list1)
            //    {
            //        if (list2.Contains(num))
            //        {
            //            result.Add(num); 
            //            list2.Remove(num); 
            //        }
            //    }

            //    return result;
            #endregion

            #region Q 10

            //ArrayList arr = new ArrayList() { 1, 2, 3, 7, 5 };
            //int target = 15;

            //int start = 0;
            //int sum = 0;

            //ArrayList result = new ArrayList();

            //for (int end = 0; end < arr.Count; end++)
            //{

            //    sum += (int)arr[end];

            //    while (sum > target && start <= end)
            //    {
            //        sum -= (int)arr[start];
            //        start++;
            //    }

            //    if (sum == target)
            //    {
            //        for (int i = start; i <= end; i++)
            //        {
            //            result.Add(arr[i]);
            //        }
            //        break;
            //    }
            //}

            //if (result.Count > 0)
            //{
            //    Console.WriteLine("Numbers that Equal The Target is : ");

            //    foreach (int num in result)
            //        Console.Write(num + " ");
            //}

            //Console.WriteLine("=======================");

            //Console.WriteLine(target);
            #endregion

            #region Q 11

            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            //int K = 3;

            //Console.WriteLine(" Queue Before : ");
            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //Stack<int> stack = new Stack<int>();

            //for (int i = 0; i < K; i++)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}

            //int Elements = queue.Count;
            //for (int i = 0; i < Elements - K; i++)
            //{
            //    queue.Enqueue(queue.Dequeue());
            //}
            //Console.WriteLine("-------------------");
            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion

        }

    } 

}
