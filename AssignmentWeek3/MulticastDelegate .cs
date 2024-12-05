//using System;

////09  Delegate	
////Extend Question 8 to create a multicast delegate that calls both the addition and subtraction methods for given inputs.



//public class Calculator
//{
//    // Addition method
//    public void Add(int a, int b)
//    {
//        Console.WriteLine("Addition Result: " + (a + b));
//    }

//    // Subtraction method
//    public void Subtract(int a, int b)
//    {
//        Console.WriteLine("Subtraction Result: " + (a - b));
//    }
//}

//public class Program
//{
    
//    public delegate void OperationDelegate(int a, int b);

//    public static void Main(string[] args)
//    {
//        Calculator calc = new Calculator();

//        OperationDelegate addDelegate = new OperationDelegate(calc.Add);
//        OperationDelegate subtractDelegate = new OperationDelegate(calc.Subtract);

//        OperationDelegate multicastDelegate = addDelegate + subtractDelegate;

//        //Multicast Delegate:
//        multicastDelegate(10, 5);
//        Console.ReadLine();
//    }
//}
