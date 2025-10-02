namespace Recursion.Easy;

/*
 *Nth Fibonacci
   The Fibonacci sequence is defined as follows: the first number of the sequence is e , the second number is 1 , and the nth number is
   the sum of the (n - l)th and (n - 2)th numbers. Write a function that takes in an integer n and retums the nth Fibonacci number.
   Important note: the Fibonacci sequence is often defined with its first two numbers as FO = @ and Fl = 1 . For the purpose of this
   question. the first Fibonacci number is FO : therefore getNthFib(1) is equal to FO , getNthFib(2) is equal to Fl . etc..

   Sample Input
    n = 6
    Sample Output
    5 // 0, 1, 1, 2, 3, 5

    Space Complexity: O(1), Time Complexity: O(2^n)
 */
public class NthFibonacci
{
    public static int GetNthFib(int n)
    {
        if (n == 2)
        {
            return 1;
        }
        else if (n == 1)
        {
            return 0;
        }
        else
        {
            return GetNthFib(n - 1) + GetNthFib(n - 2);
        }
    }
}