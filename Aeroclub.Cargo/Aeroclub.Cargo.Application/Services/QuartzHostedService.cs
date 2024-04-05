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
        _schedulerFactory = schedulerFactory ?? throw new ArgumentNullException(nameof(schedulerFactory));
        _jobFactory = jobFactory ?? throw new ArgumentNullException(nameof(jobFactory));
        _jobService = jobService ?? throw new ArgumentNullException(nameof(jobService));
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var scheduler = await _schedulerFactory.GetScheduler(cancellationToken);
        scheduler.JobFactory = _jobFactory;

        var job = JobBuilder.Create<JobService>()
            .WithIdentity("helloJob", "group1")
            .Build();

        var trigger = TriggerBuilder.Create()
            .WithIdentity("helloTrigger", "group1")
            .StartNow()
            .StartAt(DateBuilder.TodayAt(24, 0, 0))
            .WithSimpleSchedule(x => x
                .WithIntervalInHours(24)
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
