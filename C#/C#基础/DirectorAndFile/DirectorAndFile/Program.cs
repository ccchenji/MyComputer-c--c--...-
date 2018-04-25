using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectorAndFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo file = new DirectoryInfo(@"C");
            StreamAndFile(file);
            Console.Read();
        }
        public static void StreamAndFile(FileSystemInfo info)
        {
            if (!info.Exists) return;
            DirectoryInfo dir = info as DirectoryInfo;
            if (dir == null) return;
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i] as FileInfo;
                if(file!=null)
                {
                    Console.WriteLine(file.FullName+"\t"+file.Length);
                }
                else
                {
                    StreamAndFile(files[i]);
                }
            }
        }
    }
}
