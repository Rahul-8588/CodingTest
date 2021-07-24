using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                FileDetails _objFile = new FileDetails();
                if (args[0].Contains("v"))
                {
                    Console.WriteLine(_objFile.Version(args[0]));
                }
                else if (args[0].Contains("s"))
                {
                    Console.WriteLine(_objFile.Size(args[0]));
                }
            }
            Console.ReadKey();
        }
    }
}
