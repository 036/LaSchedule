using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler.Scheduler.Jobs
{
    public class FileWriterJob : IBackgroundJob
    {
        public void Handle()
        {
            Console.WriteLine("I should be writing files but here I am console writing...");
        }
    }
}
