using System;
using System.IO;

public class Task8
{
    public static void Main(string[] args)
    {
        DirectoryFilesandSubdirectories(new string[] { "C:/Users/Рустем/source/Для 8.1", "C:/Users/Рустем/source/Для 8.1/Новая папка 2" });
    }
    public static void DirectoryFilesandSubdirectories(string[] paths)
    {

        foreach (string path in paths)
        {
            if (File.Exists(path))
            {
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} не является действительным файлом или директорией.", path);
            }
        }
    }
    public static void ProcessDirectory(string targetDirectory)
    {
        string[] fileEntries = Directory.GetFiles(targetDirectory);
        foreach (string fileName in fileEntries)
            ProcessFile(fileName);

        string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
        foreach (string subdirectory in subdirectoryEntries)
            ProcessDirectory(subdirectory);
    }

    public static void ProcessFile(string path)
    {
        Console.WriteLine("{0}", path);
        Console.ReadKey();
    }
}