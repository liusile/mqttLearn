using System;

namespace MQTTnet.Exceptions
{
    /// <summary>
    /// 通讯超时异常
    /// </summary>
    public class MqttCommunicationTimedOutException : MqttCommunicationException
    {
        public MqttCommunicationTimedOutException()
        {
        }

        public MqttCommunicationTimedOutException(Exception innerException) : base(innerException)
        {
        }
    }
}
