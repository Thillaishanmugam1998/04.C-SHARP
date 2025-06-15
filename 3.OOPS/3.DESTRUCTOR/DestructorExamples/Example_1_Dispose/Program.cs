//✅ Example 1: Proper Cleanup Using Dispose()
using System;
using System.IO;

namespace Example_1_Dispose
{
    #region 01. LogWritter Class Created By Thillai
    class LogWriter: IDisposable
    {
        private StreamWriter writter;
        private bool disposed = false;

        ~LogWriter()
        {
            Dispose();
        }

        public LogWriter(string path)
        {
            writter = new StreamWriter(path, append: true);
            Console.WriteLine("File Opened...");
        }

        public void Dispose()
        {
            if(!disposed)
            {
                Console.WriteLine("Dispose: Closing File..");
                writter.Close();
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        public void Write(string Message)
        {
            writter.WriteLine($"{DateTime.Now}: {Message}");
        }

    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            #region case-1:
            using (var log = new LogWriter ("log.txt"))
            {
                log.Write("This is log message");
            }
            //After using automatically

            Console.WriteLine("Main Method Complete");
            #endregion

            #region case-2
            LogWriter log_2 = new LogWriter("log2.txt");
            log_2.Write("This is log");
            log_2.Dispose();
            #endregion

            #region case-3
            LogWriter log_4 = new LogWriter("log3.txt");
            log_2.Write("This is log");
            #endregion
        }
    }
}
