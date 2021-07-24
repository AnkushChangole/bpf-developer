using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Case 1
            //if(args[0]=="-v")
            //{
            //    FileDetails _fileDetails = new FileDetails();
            //    string version= _fileDetails.Version(args[1]);
            //    Console.WriteLine(version);
            //}

            // Read allowed version and size specification from config
            string[] versions = ConfigurationManager.AppSettings["versionArguments"].Split(',');
            string[] sizes = ConfigurationManager.AppSettings["sizeArguments"].Split(',');

            // check if specified version attribute contains in allowed version specified in config
            if (versions.Contains(args[0]))
            {
                FileDetails _fileDetails = new FileDetails();
                string version = _fileDetails.Version(args[1]);
                Console.WriteLine(version);
                
            }

            // check if specified size attribute contains in allowed version specified in config
            if (sizes.Contains(args[0]))
            {
                FileDetails _fileDetails = new FileDetails();
                double version = _fileDetails.Size(args[1]);
                Console.WriteLine(version);
            }
            Console.ReadLine();
        }

    }
}
