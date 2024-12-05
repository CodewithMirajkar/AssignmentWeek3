//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////Deleting a File
////Write a program that deletes a file named delete_me.txt. Ensure the file exists before attempting to delete it.

//namespace FileHanding
//{
//    internal class _06DeleteFile
//    {
//        public static void Main(string[] args)
//        {

//            string filePath = "C:\\CSharp\\sample_Copy.txt";

//            try
//            {

//                if (File.Exists(filePath))
//                {

//                    File.Delete(filePath);


//                    Console.WriteLine("File deleted successfully.");
//                }
//                else
//                {

//                    Console.WriteLine("File does not exist.");
//                }
//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine("An error occurred: " + ex.Message);
//            }
//            Console.ReadLine();
//        }
//    }
//}

