using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.Web
{
    public class DBLog : ILog
    {
        public void Write(string msg)
        {
            //假设这里是存入数据库
            Debug.WriteLine("DBLog:" + msg);
        }
    }
}
