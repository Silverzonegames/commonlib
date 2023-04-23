using Silverzone.CommonLib.Ex;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace Silverzone.CommonLib.Log
{
    public static class Logger
    {
        private static string m_exePath = string.Empty;
        private static string _log = "Logs";
        private static string m_logPath = Path.Combine(m_exePath, _log);
        public static Task LoggerInit()
        {
            if (!Directory.Exists(m_logPath)) {
                try
                {
                    Directory.CreateDirectory(m_logPath);
                }
                catch (Exception e) {
                    Debug.Write(e);
                    return Task.FromException(e);
                }
            }
            return Task.CompletedTask;
        }
        public static void LogWrite(string logMessage)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (m_exePath.Length <= 0) throw new CLibEx.MissingOrInvalidPath();
            try
            {
                using (StreamWriter w = new StreamWriter(m_logPath + "\\latest.log"))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception e){
            }
        }

        internal static Task Log(string logMessage, TextWriter w)
        {
            try
            {
                w.Write("\n\rLog entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", logMessage);
                w.WriteLine("------------------");
                
            }
            catch (Exception e) {

            }
            return Task.CompletedTask;
        }
    }
}
