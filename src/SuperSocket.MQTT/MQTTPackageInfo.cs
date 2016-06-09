namespace SuperSocket.MQTT
{
    public class MQTTPackageInfo : IPackageInfo
    {
        public ControlPacketType Type { get; set; }

        public byte Flags { get; set; }
    }
}