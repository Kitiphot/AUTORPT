using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using SCG.ARS.BOI.WEB.Schedule;

namespace SCG.ARS.BOI.WEB.Schedule {
    public class StdSchedulerFactoryEx : StdSchedulerFactory {
        //private readonly ISchedulerFactory _schedulerFactory;
        private readonly IJobFactory _jobFactory;
        private readonly IEnumerable<JobSchedule> _jobSchedules;

        public IScheduler Scheduler { get; set; }

        public StdSchedulerFactoryEx (
            IJobFactory jobFactory,
            IEnumerable<JobSchedule> jobSchedules) {
            _jobSchedules = jobSchedules;
            _jobFactory = jobFactory;

            Scheduler = this.GetScheduler ().Result;
        }

        public void Start () {
            Scheduler.JobFactory = _jobFactory;

            foreach (var jobSchedule in _jobSchedules) {
                var job = CreateJob (jobSchedule);
                var trigger = CreateTrigger (jobSchedule);

                Scheduler.ScheduleJob (job, trigger);
            }

            Scheduler.Start ();
        }

        public void AddJob<T> (string group = "DEFAULT") {
            var jobType = typeof (T);
            var jobKey = JobKey.Create (jobType.Name, group);
            IJobDetail jobDetail = JobBuilder.Create (jobType)
                .WithIdentity (jobKey)
                .StoreDurably (true)
                .Build ();
            Scheduler.AddJob (jobDetail, true);
        }

        public void AddJob<T>(JobDataMap jobDataMap, string group = "DEFAULT")
        {
            var jobType = typeof(T);
            var jobKey = JobKey.Create(jobType.Name, "DEFAULT");
            IJobDetail jobDetail = JobBuilder.Create(jobType)
                .WithIdentity(jobKey)
                .StoreDurably(true)
                .SetJobData(jobDataMap)
                .Build();
            Scheduler.AddJob(jobDetail, true);
        }

        private static IJobDetail CreateJob (JobSchedule schedule) {
            var jobType = schedule.JobType;
            return JobBuilder
                .Create (jobType)
                .WithIdentity (jobType.Name)
                .WithDescription (jobType.FullName)
                .Build ();
        }

        private static ITrigger CreateTrigger (JobSchedule schedule) {
            return TriggerBuilder
                .Create ()
                .WithIdentity ($"{schedule.JobType.Name}.trigger")
                .WithCronSchedule (schedule.CronExpression)
                .WithDescription (schedule.CronExpression)
                .Build ();
        }
    }
}