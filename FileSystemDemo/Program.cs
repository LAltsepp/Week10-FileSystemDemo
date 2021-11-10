using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\C#Projects\Temp\Demo\FileSystem";

            //Get the names of all the directories 
            ////string[] dirs = Directory.GetDirectories(rootPath);

            //Get the names of all the directories and the subdirectories
            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //Get all the files in all the directories
            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            //just the files with txt extension 
            //var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);
            //just the files who contains "folder"
            //var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            //    //Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));

            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{ Path.GetFileName(file) }: {info.Length } bytes");

            //}

            //string newPath = @"D:\C#Projects\Temp\Demo\FileSystem\SubFolderC\SubSubFolder";

            //create the directory 
            ////bool directoryExists = Directory.Exists(newPath);

            ////if (directoryExists)
            ////{
            ////    Console.WriteLine("The directory exists");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("The directory does not exist");
            ////}

            ////create the directory (shortcut) and will check if its exists
            //Directory.CreateDirectory(newPath);

            string[] files = Directory.GetFiles(rootPath);
            string destinationFolder = @"C:\C#Projects\Temp\Demo\FileSystem\SubFolderA";

            //copy files with their names
            ////foreach (string file in files)
            ////{
            ////    File.Copy(file, $"{destinationFolder}{Path.GetFileName(file)}", true);
            ////}

            //copy files and change their names with 0,1,2, etc.
            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{i}.txt", false);
            //}

            //to move files
            foreach (string file in files)
            {
                File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}");
            }
            Console.ReadLine();
        }
    }
}
