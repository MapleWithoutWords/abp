using System;
using System.Threading.Tasks;

namespace Volo.Abp.EventBus.Distributed;

public class MySimpleDistributedTransientEventHandler : IDistributedEventHandler<MySimpleEventData>, IDisposable
{
    public static int HandleCount { get; set; }

    public static int DisposeCount { get; set; }

    public int Order { get; set; }

    public Task HandleEventAsync(MySimpleEventData eventData)
    {
        ++HandleCount;
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        ++DisposeCount;
    }
}
