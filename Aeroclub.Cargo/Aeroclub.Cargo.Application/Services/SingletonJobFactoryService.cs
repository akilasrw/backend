using Quartz;
using Quartz.Spi;
using System;

public class SingletonJobFactory : IJobFactory
{
    private readonly IServiceProvider _serviceProvider;

    public SingletonJobFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
    {
        try
        {
            var jobDetail = bundle.JobDetail;
            Type jobType = jobDetail.JobType;
            return (IJob)_serviceProvider.GetService(jobType);
        }
        catch (Exception ex)
        {
            throw new SchedulerException($"Problem while instantiating job '{bundle.JobDetail.Key}' from the {nameof(SingletonJobFactory)}: {ex.Message}");
        }
    }

    public void ReturnJob(IJob job) { }
}
