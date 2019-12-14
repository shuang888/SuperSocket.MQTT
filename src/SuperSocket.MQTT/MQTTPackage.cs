using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT
{
    public class MQTTPackage
    {
        public ControlPacketType Type { get; set; }

        public byte Flags { get; set; }
    }
}