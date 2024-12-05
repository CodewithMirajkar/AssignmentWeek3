//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
///// Simple Delegate
////Create a delegate named MathOperation that takes two integers and returns an integer. Write two methods, one for addition and one for subtraction.Use the delegate to invoke these methods.

//namespace PraticeCode
//{
//    class greek
//    {
//        public delegate void addnum(int x, int y);
//        public delegate void subnum(int x, int y);
//        public void sum(int x, int y)
//        {
//            Console.WriteLine( x + y);
//        }
//        public void subtract(int x, int y)
//        {
//            Console.WriteLine( x - y);
//        }


//        internal class Delegate01
//        {
//            public static void Main(string[] args)
//            {
//                greek obj = new greek();
//                addnum del_obj1 = new addnum(obj.sum);
//                subnum del_obj2 = new subnum(obj.subtract);
//                del_obj1(100, 40);
//                del_obj2(100, 40);
//                Console.ReadLine();
//            }
//        }
//    }
//}
