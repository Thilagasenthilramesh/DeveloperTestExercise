using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    //Code start By Thilagasenthilramesh @ 21-03-2019 4:52pm
    public static class Program
    {       
        static readonly string[] strAVersion = { "-v", "--v", "/v" ,"--version"};
        static readonly string[] strASize = { "-s", "--s", "/s","--size" };
        public static void Main(string[] args)
        {
            FileDetails fd = new FileDetails();
            if (args.Length < 2)
            {
                Console.WriteLine("Please Enter Version/Size and FileName Arguments ");
            }
            else if (args.Length > 0)
            {               
                string strVerOrSize = args[0];
                String strFilePath = args[1];
                //Console.WriteLine(args[0]);
                //Console.WriteLine(args[1]);
                if (strAVersion.Contains(strVerOrSize.ToLower()))
                {
                    Console.WriteLine("Version Details: ");
                    Console.WriteLine(fd.Version(strFilePath));
                }
                else if (strASize.Contains(strVerOrSize.ToLower()))
                {
                    Console.WriteLine("Size Details: ");
                    Console.WriteLine(fd.Size(strFilePath));
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Version/Size ");
                }
            }
        }
    } //Code finished by Thilagasenthilramesh @ 21-03-2019 5:20pm
}


