using System;
using System.Threading.Tasks;
using MQTTnet.Server;

namespace MQTTnet.Adapter
{
    /// <summary>
    /// mqtt服务层
    /// </summary>
    public interface IMqttServerAdapter : IDisposable
    {
        Func<IMqttChannelAdapter, Task> ClientHandler { get; set; }

        Task StartAsync(IMqttServerOptions options);
        Task StopAsync();
    }
}
