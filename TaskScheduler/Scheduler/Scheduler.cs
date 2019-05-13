using System;
using System.Collections.Generic;
using System.Text;
using TaskScheduler.Scheduler.Jobs;

namespace TaskScheduler.Scheduler
{
    public class Scheduler
    {
        private readonly List<Type> _events;

        public void Call<T>() where T : IBackgroundJob
        {
            _events.Add(typeof(T));
        }
    }
}
