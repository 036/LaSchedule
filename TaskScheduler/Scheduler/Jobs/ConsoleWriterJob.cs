using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler.Scheduler.Jobs
{
    public class ConsoleWriterJob : IBackgroundJob
    {
        public void Handle()
        {
            // Would likely use DI and use the method so not all the logic is handled in the 'handle' method.
            Console.WriteLine("I'm writing a line and nobody can see me");
        }
    }
}
