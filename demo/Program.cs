namespace demo
{

    internal class Program
    {
        #region function prototype and calling
        //static void printshape() { 
        //for(int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine($"*_*");
        //    }

        //}

        //entry point

        #endregion

        /*
       static void printshape(int count = 5, string shape = "$_$")
      {
          for (int i = 1; i <= count; i++)
          {
              Console.WriteLine($"{shape}");
          }

      }*/ //passing by value


        #region value type parameters
        //static void swap(ref int x, ref int y) //passing by ref
        //{
        //    Console.WriteLine("swap");
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //} 
        #endregion

        ///passing by value
        //static int sumarray(int[] arr)
        //{ 
        //    int sum = 0;
        //    if (arr != null)
        //    {
        //        arr[0] = 100;
        //        arr =new int []{4,5,6};     
        //        for(int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //        return sum;

        //}

        ///passing by referencer
        #region reference type parameters
        //static int sumarray(ref int[] arr)
        //{
        //    int sum = 0;
        //    if (arr != null)
        //    {
        //        arr[0] = 100;
        //        arr =new int []{4,5,6};     

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //        return sum;
        //    }
        //} 
        #endregion

        #region passing by out
        //static void summul(int x, int y, out int sum, out int mul)
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}

        #endregion

        #region params
        //static int sumarray(int x, int y = 5, params int[] arr)
        //{
        //    int sum = 0;
        //    if (arr != null)
        //    {

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //        return sum;


        //    }
        //    return sum;

        //} 
        #endregion

        #region Exception Handeling and Protective Code
        ///static void DoSomeOcde()
        ///{
        ///    try
        ///    {
        ///                        int X, Y, Z;
        ///                      X = int.Parse(Console.ReadLine());
        ///        Y = int.Parse(Console.ReadLine());
        ///        Z = X / Y;
        ///
        ///        int[] Arr = { 1, 2, 3 };
        ///        Arr[100] = 22;
        ///    }
        ///                                      1  // catch (FormatException ex)
        ///    {
        ///        Console.WriteLine(ex.Message);
        ///    }
        ///                                       2  catch (DivideByZeroException ex)
        ///    {
        ///        Console.WriteLine(ex.Message);
        ///    }
        ///                                       3  catch (IndexOutOfRangeException ex)
        ///    {
        ///        Console.WriteLine(ex.Message);
        ///    }
        ///                                        4    catch (Exception ex)
        ///    {
        ///        Console.WriteLine(ex.Message);
        ///    }
        ///
        ///}


        ///static void DoSomeProtectiveCode()
        ///{
        ///
        ///    int X, Y, Z;
        ///    do
        ///    {
        ///        Console.Write("Plz Enter First Number: ");
        ///
        ///    } while (!int.TryParse(Console.ReadLine(), out X));
        ///
        ///    do
        ///    {
        ///        Console.Write("Plz Enter Second Number: ");
        ///    } while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);
        ///
        ///    Z = X / Y;
        ///
        ///    int[] Arr = { 1, 2, 3 };
        ///
        ///    if (Arr?.Length > 100)
        ///    {
        ///        Arr[100] = 22;
        ///    }
        ///}

        #endregion
        static void Main(string[] args)
        {
            #region functions
            #region function prototype and calling

            //printshape(15,"$_$"); //passing parameter with same order
            //printshape(shape:"$_$",count:15); //passing parameter with name

            //printshape();
            //printshape(10);
            //printshape(shape:"######");

            //printshape(20,@"/*\");

            //string folder = "E:\\EXAM_02";

            //Console.WriteLine("hi \nahmed \tnas\\r"); 
            #endregion

            #region value type parameters

            // int a = 3, b = 5;
            // Console.WriteLine($"A= {a}"); //3
            // Console.WriteLine($"b= {b}"); //5

            // //swap(a, b);  //1.passing by value [input parameter] 
            // //             // swap(3,5);

            //// swap(ref a, ref b); //2.passing by ref [input output parameters]


            // Console.WriteLine($"A= {a}");
            // Console.WriteLine($"b= {b}"); 
            #endregion

            #region referencr type parameters
            //int[] numbers = { 1, 2, 3, 4 };

            ////sumarray(numbers); //passing by value
            ////                   //sumarray(address of array)


            ////sumarray(ref numbers); //passing by reference
            ////                   //sumarray(address of array)

            //Console.WriteLine(numbers[0]); 
            #endregion

            #region passing by out

            //int a = 3, b = 4, sresult, mresult;
            //summul(a, b, out sresult, out mresult); //passing by out

            //Console.WriteLine($"restur sum is {sresult}");

            //Console.WriteLine($"restur mul is {mresult}"); 
            #endregion

            #region params

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = sumarray(1, 2, 3, 4, 5);
            //Console.WriteLine($"sum of array {total}");
            //Console.WriteLine("{0}+{1}+{2}={2}+{4}", 10, 20, 35, 5, "hamda"); 
            #endregion
            #endregion

            #region Boxing and Unboxing
            ///// Boxing   : Casting From DataType[ValueType] to DataType[ReferenceType].
            //// UnBoxing : Casting From DataType[ReferenceType] to DataType[ValueType].

            #region example1
            // object obj;
            ///Declare for       RefernceType of type "object",  Refereing to The default value of RefernceType = null
            ///This   Refernce will be allocated at stack with size = 4 Bytes
            ///       This Reference can refer to object from type "object" or any another type inherting from "object"

            //obj = new object();
            //obj = new string("Ahmed");
            //obj = "Ahmed";

            //obj = 'A';//Casting From char[ValueType] to object[ReferenceType]  == Boxing
            //obj = 5;//Casting From int[ValueType] to object[ReferenceType]    == Boxing
            //obj = 5.5;//Casting From double[ValueType] to object[ReferenceType]  == Boxing
            //obj = true;//Casting From bool[ValueType] to object[ReferenceType]     == Boxing


            //bool flag = (bool)obj;
            ////Casting From object[ReferenceType] to boll[ValueType]==== UnBoxing 
            #endregion

            #region Example 02
            #region Boxing

            //int X = 10;
            //object obj = X;
            // Casting From int[ValueType] to object[ReferenceType] Implicitly
            //10 ------> new object(10)
            // Boxing [Safe Casting]

            //Console.WriteLine(obj); //10 
            #endregion

            #region UnBoxing

            //object obj = 20;
            ////obj = "Ahmed";

            //int Y = (int)obj;
            // Casting From object[ReferenceType] to int[ValueType] Explicitly
            // new object(20) ------> 20
            // UnBoxing [UnSafe Casting] 
            //
            //Console.WriteLine(Y);

            #endregion

            #endregion

            #endregion

            #region Inhertiance: is
            //object obj;
            //obj = new object();

            //obj = new string("Ahmed"); // String is a object
            // parent = Childx
            // Animal = Dog  
            #endregion

            #region Nullable ValueTypes [C# 2.0 (2005)]

            //null: is not a valid value for the variables of dataTybe:[ValueType](Struct, enum)
            //Nullable ValueTypes = ValueTypes + Allow Null As a valid Value
            #region Part 01

            //                      Nullable<int> Age;
            //int? Age;
            //Age = null;

            //                       Nullable<decimal> Salary;
            //decimal? Salary;
            //Salary = null;
            //Salary = 6000;

            #endregion


            #region Casting From int to Nullable<int>
            //int X = 10
            // X: int            -- Allow Integers only
            // Y: Nullable<int>  --   Allow Integers + null
            //int? Y = X;

            // Casting From int to Nullable<int> happen Implicitly
            // Safe Casting

            //Console.WriteLine(Y); 
            #endregion

            #region Casting From Nullable<int> to int && null coalescing operator 
            //int? X = 10;   is same to     //Nullable<int> X;

            //X = null;

            // X: Nullable<int>   ---   Allow Integers + null
            // Y: int             ---   Allow Integers only

            //int Y = (int)X;


            // Casting From Nullable<int> to int happen Explicitly     // UnSafe Casting


            //Protective Code
            //   1.  //if (X is not null)
            //{
            //    Y = (int)X;
            //}
            //else
            //    Y = 0;
            /////////////////////////////////////////////////////////////////////////
            ///
            //// 2.
            //if (X.HasValue)
            //{
            //    Y = (int)X.Value;
            //}
            //else
            //    Y = 0;

            /////////////////////////////////////////////////////////////////////////


            //3.
            //Y= X.HasValue ? X.Value : 0;

            /////////////////////////////////////////////////////////////////////////

            //4.
            //Y = X ?? 0;
            // ?? -- null coalescing operator [Synta Sugar] 
            #endregion


            #endregion


            #region Nullable RefernceTypes [C# 10.0 (2021)]
            // null: is  a valid value for the variables
            // of dataTybe:[RefernceTypes](Class, interface)

            //string Message01 = null!;
            //! null forgiveness operator
            //Console.WriteLine(Message01);

            //string? Message02 = null;

            //Console.WriteLine(Message02);

            #endregion

            #region null propagation operator

            #region Example 01
            //decimal Salary = default; //0

            //int[]? Numbers = default;           //null

            //if (Numbers is not null)
            //{
            //    for (int i = 0; i < Numbers.Length /* Dereferencing */; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}

            //for (int i = 0; i < Numbers?.Length /* Dereferencing */; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //if (Numbers is not null)
            //{
            //    int Len01 = Numbers.Length;
            //}

            //// null propagation operator
            //int Len2 = Numbers?.Length ?? 0;

            ////Syntax Sugar
            ////int? Len02 = Numbers is not null ? Numbers.Length : null; 
            #endregion

            #region Example 02

            //Employee employee = new Employee()
            //{
            //    Id = 10,
            //    Age = 22,
            //    Name = "Ahmed Nasr",
            //    Department = new Department()
            //    {
            //        Code = 1001,
            //        Name = "Sales"
            //    }
            //};

            //if (employee is not null)
            //{
            //    if (employee.Department is not null)
            //    {
            //        if (employee.Department.Name is not null)
            //        {
            //            Console.WriteLine(employee.Department.Name); 
            //        }
            //        else
            //            Console.WriteLine("no name");
            //    }
            //}
            //Console.WriteLine(employee?.Department?.Name ?? "No Name");
            #endregion

            #endregion

            #region Exception Handeling and Protective Code
            //DoSomeOcde();
            //try
            //{
            //    DoSomeProtectiveCode();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            // free \ Deallocate \ delete  \ close UnManaged Resources "DB conection , File"
            //}


            /*Exceptions
             //1. System Exceptions
            //1.FormatExceptions
            //2.IndexOutOfRangeException
            //3.NullReferenceException
            //4.InvalidOperationException
            //5.ArithmeticException
            //2. ApplicationExceptions
             */
            #endregion


        }
    }
}
