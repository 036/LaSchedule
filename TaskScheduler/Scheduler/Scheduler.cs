using System;
using System.Collections.Generic;
using System.Text;
using TaskScheduler.Scheduler.Jobs;

namespace TaskScheduler.Scheduler
{
    public class Scheduler
    {
        public void Call<T>() where T : IBackgroundJob
        {

        }
    }
}
