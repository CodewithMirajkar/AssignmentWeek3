//using System;
//using System.IO;
//// Copying a File
//// Create a program to copy the contents of a file source.txt to another file destination.txt. If the destination file exists, overwrite it.

//namespace filehanding
//{
//    internal class _04copyfile
//    {
//        public static void Main(string[] args)
//        {

//            string sourceFilePath = "C:\\CSharp\\source.txt";
//            string destinationFilePath = "C:\\CSharp\\source.txt";


//            {

//                File.Copy(sourceFilePath, destinationFilePath, overwrite: true);

//                Console.WriteLine($"File copied successfully from '{sourceFilePath}' to '{destinationFilePath}'.");


//                string sourceContent = File.ReadAllText(sourceFilePath);
//                string destContent = File.ReadAllText(destinationFilePath);
//                Console.WriteLine("copy Successfully");
//                Console.ReadLine();

//            }



//        }
//    }
//}
