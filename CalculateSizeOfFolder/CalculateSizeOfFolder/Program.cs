using System;
using System.IO;
using System.Linq;

namespace CalculateSizeOfFolder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DirectoryInfo dInfo = new DirectoryInfo(@"CalculateSizeOfFolder.exe/");

            Console.WriteLine(dInfo);

            long sizeOfDir = DirectorySize(dInfo, true);

            Console.WriteLine("Directory size in Bytes : {0} Bytes", sizeOfDir);
            Console.WriteLine("Directory size in KB : {0} KB", ((double)sizeOfDir) / 1024);
            Console.WriteLine("Directory size in MB : {0} MB", ((double)sizeOfDir) / (1024 * 1024));
        }
        static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            long totalSize = dInfo.EnumerateFiles().Sum(file => file.Length);

            if (includeSubDir)
            {
                totalSize += dInfo.EnumerateDirectories().Sum(dir => DirectorySize(dir, true));
            }

            return totalSize;
        }
    }
}
