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
        private static string ExeCMD(string exeargs)
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
            var response = ExeCMD("/getactivescheme");
            return response;
        }
        public static string GetSchemes()
        {
            var response = ExeCMD("/list");
            return response;
        }

        public static void NewLine(string obj)
        {
            //obj.Text
        }
    }

}