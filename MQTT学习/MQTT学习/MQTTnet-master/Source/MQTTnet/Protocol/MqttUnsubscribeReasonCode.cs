namespace MQTTnet.Protocol
{
    public enum MqttUnsubscribeReasonCode
    {
        Success = 0,
        NoSubscriptionExisted = 17,
        UnspecifiedError = 128,
        ImplementationSpecificError = 131,
        /// <summary>
        /// 无权限
        /// </summary>
        NotAuthorized = 135,
        /// <summary>
        /// 
        /// </summary>
        TopicFilterInvalid = 143,
        PacketIdentifierInUse = 145
    }
}
