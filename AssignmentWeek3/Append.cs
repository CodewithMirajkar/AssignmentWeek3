﻿//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//// 03 Appending to a File
////Modify the program from Question 2 to append the text "This is a new line." to the file.

//namespace FileHanding
//{
//    internal class _02AppendTextExistingFile
//    {
//        public static void Main(string[] args)
//        {
//            // Define the path of the file
//            string filePath = "C:\\CSharp\\sample.txt";


//            {

//                using (StreamWriter writer = new StreamWriter(filePath, append: true))
//                {
//                    writer.WriteLine("Welcome to file handling in C#.");

//                }
//                string fileContents = File.ReadAllText(filePath);
//                Console.WriteLine("\nUpdated file contents:");
//                Console.WriteLine(fileContents);

//            }

//        }
//    }
//}
