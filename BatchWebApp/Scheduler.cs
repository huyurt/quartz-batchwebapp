using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Quartz;
using Quartz.Impl;

namespace BatchWebApp
{
    public static class Scheduler
    {
        public static async Task<IScheduler> Create(bool start = true)
        {
            var scheduler = await StdSchedulerFactory.GetDefaultScheduler();

            if (start)
                await scheduler.Start();

            return scheduler;
        }
    }
}