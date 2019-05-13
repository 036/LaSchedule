using System;
using System.Collections.Generic;
using System.Text;
using TaskScheduler.Scheduler.Jobs;

namespace TaskScheduler.Scheduler
{
    public class TaskScheduler
    {
        public void RunSchedule()
        {
            var scheduler = new Scheduler();

            scheduler.Call<ConsoleWriterJob>();
        }
    }
}
