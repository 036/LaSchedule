using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler.Scheduler.Jobs
{
    public interface IBackgroundJob
    {
        void Handle();
    }
}
