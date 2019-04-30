using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utils
{
    public class SimpleLog
    {
        // 将信息写入运行目录
        public static void WriteLog(string message)
        {
            string filepath = System.AppDomain.CurrentDomain.BaseDirectory + "\\log\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            if (File.Exists(filepath))
            {
                File.Create(filepath).Close(); // 创建后，立即关闭流。
            }
            message = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " --> " + message + "\r\n";
            var logContentBytes = Encoding.UTF8.GetBytes(message);
            using (FileStream logFile = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                logFile.Seek(0, SeekOrigin.End);
                logFile.Write(logContentBytes, 0, logContentBytes.Length);
            }
        }

        public static void WriteLogToFile(string message,string filePath,Encoding encoding)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            message = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " --> " + message + "\r\n";
            var logContentBytes = encoding.GetBytes(message);
            using (FileStream logFile = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                logFile.Seek(0, SeekOrigin.End);
                logFile.Write(logContentBytes, 0, logContentBytes.Length);
            }
        }
    }
}
