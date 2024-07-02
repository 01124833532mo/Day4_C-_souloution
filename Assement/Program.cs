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

        }
    }
}
