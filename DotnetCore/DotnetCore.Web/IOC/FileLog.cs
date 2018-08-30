using System.Diagnostics;

namespace DotnetCore.Web
{
    public class FileLog : ILog
    {
        public void Write(string msg)
        {
            Debug.WriteLine("FileLog:" + msg);
        }
    }
}
