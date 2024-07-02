using System.Diagnostics.CodeAnalysis;

namespace Assement
{
    internal class Program
    {
        #region question 2 passing by value
        //static int sumarray(int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null)
        //    {
        //       // arr[0] = 100;
        //        arr = new int[] { 4, 5, 6 };
        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];
        //    }
        //    return sum;

        //}
        #endregion


        #region question 3
        //public static void Calculate(double a, double b, double c, double d,out double sum,out double sub)
        //{
        //    sum = a + b + c + d;
        //    sub = (a + b) - (c + d);
        //}

        #endregion
        #region question 4
        //static int oddnumer(int number)
        //{
        //    int sum = 0;
        //    while(number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        #endregion
        #region question 5
        // static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;
        //    if (number == 2) return true;
        //    if (number % 2 == 0) return false; 

        //    int boundary = (int)Math.Floor(Math.Sqrt(number));

        //    for (int i = 3; i <= boundary; i += 2)
        //    {
        //        if (number % i == 0) return false;
        //    }

        //    return true;
        //}

        #region question 6
        //static void MinMaxArray(ref int[] arr, out int min,out int max)
        //{
        //    Array.Sort(arr);
        //    min = arr[0];
        //    max = arr[arr.Length - 1];
        //}
        #endregion

        static void Main(string[] args)
        {
            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //passing by value
            //passing parameters can refer to references of of object or class and conseder input parameters and it same of passing by reference but diffrent behiviour
            // passing by value
            //int[] numbers = { 1, 2, 3, 4 };
            //sumarray(numbers);
            //Console.WriteLine(numbers[0]); // output 1

            //cant arr acsses on numbers because arr inishilized new object that refer to that and 

            //passing by ref
            //can parameter acsses on basic parameters in stack to refer that and consider input-output parameters and arr refer to address of numbers
            //int[] numbers = { 1, 2, 3, 4 };
            //sumarray(ref numbers);
            //Console.WriteLine(numbers[0]); // output 4
            ////can acsses on new array because refer to that 

            #endregion

            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            // Console.Write("Enter the first number");
            // double num1;
            //bool flag1= double.TryParse(Console.ReadLine(), out num1);

            // Console.Write("Enter the second number: ");
            // double num2;
            // bool flag2=   double.TryParse(Console.ReadLine(), out num2);

            // Console.Write("Enter the third number: ");
            // double num3;
            // bool flag3 =double.TryParse(Console.ReadLine(), out num3);

            // Console.Write("Enter the fourth number: ");
            // double num4;
            // bool flag4= double.TryParse(Console.ReadLine(), out num4);

            // double sumResult;
            // double subtractResult;
            // if (!(flag1 && flag2 && flag3 && flag4))
            // {
            //     Console.WriteLine("can not ");
            // }
            // else {
            //     Calculate(num1, num2, num3, num4, out sumResult, out subtractResult);

            //     Console.WriteLine($"Summation Result: {sumResult}");
            //     Console.WriteLine($"Subtraction Result: {subtractResult}"); }
            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            //Console.WriteLine("please enter number");
            //int num = int.Parse(Console.ReadLine());
            //int res = oddnumer(num);
            //Console.WriteLine($" sum of digit is {res}");
            #endregion

            #region 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.Write("Enter a number: ");
            //int number = int.Parse((Console.ReadLine()));

            //bool isPrime = IsPrime(number);

            //if (isPrime)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameter
            //int[] numbers = { 1, 5, 7, 34, 5, 6, 7 };
            //int resmin;
            //int resmax;
            //MinMaxArray(ref numbers, out resmin, out resmax);

            //Console.WriteLine($"minimum element is {resmin} ");
            //Console.WriteLine($"maximum element is {resmax} ");

            #endregion
        }
    }
}
