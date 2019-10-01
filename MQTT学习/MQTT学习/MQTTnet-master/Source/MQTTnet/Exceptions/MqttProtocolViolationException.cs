using System;

namespace MQTTnet.Exceptions
{

    public class MqttProtocolViolationException : Exception
    {  
        /// <summary>
         /// 违反协议异常
         /// </summary>
        public MqttProtocolViolationException(string message)
            : base(message)
        {
        }
    }
}
