using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace projects
{
    internal class StopWatch
    {
        public static void ElapsedTime()
        {
            //created Object of Stopwatch class
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Hit Enter to start Watch");
            stopWatch.Start();    //Timmer started.
            Thread.Sleep(6000);  
            Console.WriteLine("Hit Enter to stop Watch");

            stopWatch.Stop();   //Timer stopped
            Console.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds);
        }
    }
}
