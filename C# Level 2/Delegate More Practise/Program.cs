using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    public class Logger
    {
        public delegate void LogAction(string message);
        private LogAction _LogAction;
        public Logger(LogAction action)
        { _LogAction = action; }

        public void Log(string message)
        { 
            _LogAction(message);
        }

    }
  
    public  class Program
    {

        public static void LogToScrren(string message)
        {
            Console.WriteLine(message);
        }
        
        public static void LogToFile(string message)
        {
             string FileName = "TxtFile.txt";
             using(StreamWriter writer = new StreamWriter(FileName))
             { 
                writer.WriteLine(message);
             }
        }
        
        static void Main(string[] args)
        {
            Logger logger = new Logger(LogToFile);
            Logger logger1 = new Logger(LogToScrren);

            logger.Log("Write to File");
            logger1.Log("write To The Screen");
            Console.ReadKey();
        
        }
    }

