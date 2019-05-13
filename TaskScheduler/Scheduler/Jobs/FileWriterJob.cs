using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler.Scheduler.Jobs
{
    public class FileWriterJob : IBackgroundJob
    {
        public void Handle()
        {
            // Do some file write here...
        }
    }
}
