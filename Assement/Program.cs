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


        }
    }
}
