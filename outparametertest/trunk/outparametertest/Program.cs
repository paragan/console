using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace outparametertest
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://esro.eno.org/Customfeeds/performance.aspx?@FromEventDate=YYYY-MM-DD&@ToEventDate=YYYY-MM-DD
             DateTime curDate = new DateTime(2014,9,20);
             Console.WriteLine("the datetime is---"+curDate);
             Console.WriteLine(curDate.AddDays(-1).ToString("yyyy-MM-dd"));
             Console.WriteLine(curDate.AddDays(-2).ToString("yyyy-MM-dd"));
             Console.Read();
        }
    }
}
