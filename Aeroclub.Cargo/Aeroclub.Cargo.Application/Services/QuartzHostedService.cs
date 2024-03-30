using Aeroclub.Cargo.Application.Services;
using Microsoft.Extensions.Hosting;
using Quartz;
using Quartz.Spi;
using System;
using System.Threading;
using System.Threading.Tasks;

public class QuartzHostedService : IHostedService
{
    private readonly ISchedulerFactory _schedulerFactory;
    private readonly IJobFactory _jobFactory;
    private readonly JobService _jobService;

    public QuartzHostedService(ISchedulerFactory schedulerFactory, IJobFactory jobFactory, JobService jobService)
    {
        _schedulerFactory = schedulerFactory;
        _jobFactory = jobFactory;
        _jobService = jobService;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        IScheduler scheduler = await _schedulerFactory.GetScheduler(cancellationToken);
        scheduler.JobFactory = _jobFactory;

        IJobDetail job = JobBuilder.Create<JobService>()
            .WithIdentity("helloJob", "group1")
            .Build();

        ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("helloTrigger", "group1")
            .StartNow()
            .WithSimpleSchedule(x => x
                .WithIntervalInSeconds(10) // set interval here
                .RepeatForever())
            .Build();

        await scheduler.ScheduleJob(job, trigger, cancellationToken);
        await scheduler.Start(cancellationToken);
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
