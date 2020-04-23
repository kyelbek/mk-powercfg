using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mk_powercfg
{
    public static class ExtMethods
    {
        private static string PowerCFG(string exeargs)
        {
            string output = null;
            try
            {
                var powercfg = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "powercfg.exe",
                        Arguments = exeargs,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.GetEncoding(852)
                    }
                };
                powercfg.Start();
                while (!powercfg.StandardOutput.EndOfStream)
                {
                    output += powercfg.StandardOutput.ReadLine();
                    output += Environment.NewLine;
                    //output += "...";
                }
                powercfg.WaitForExit();
            }
            catch (Exception e)
            {
                output = e.Message;
            }
            return output;
        }
        public static string GetActiveScheme()
        {
            var response = PowerCFG("/getactivescheme");
            return response;
        }
        public static string GetSchemes()
        {
            var response = PowerCFG("/list");
            return response;
        }
        public static int CountLines(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");
            if (str == string.Empty)
                return 0;
            int index = -1;
            int count = 0;
            while (-1 != (index = str.IndexOf(Environment.NewLine, index + 1)))
                count++;
            return count + 1;
        }
        public static int Count4(string s)
        {
            int n = 0;
            foreach (var c in s)
            {
                if (c == '\n') n++;
            }
            return n + 1;
        }
    }

}