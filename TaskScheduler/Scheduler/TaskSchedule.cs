using System;
using System.Collections.Generic;
using System.Text;
using TaskScheduler.Scheduler.Jobs;

namespace TaskScheduler.Scheduler
{
    public class TaskSchedule
    {
        public void RunSchedule()
        {
            var scheduler = new ScheduleHandler();

            scheduler.Call<ConsoleWriterJob>();
            scheduler.Call<FileWriterJob>();
        }
    }
}
