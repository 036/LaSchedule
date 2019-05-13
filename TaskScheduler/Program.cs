using TaskScheduler.Scheduler;

namespace TaskScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskSchedule = new TaskSchedule();
            taskSchedule.RunSchedule();
        }
    }
}
