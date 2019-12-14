using System.Buffers;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT
{
    public abstract class MQTTPacket
    {
        public ControlPacketType Type { get; set; }

        public byte Flags { get; set; }
        
        internal protected abstract void DecodeBody(ref SequenceReader<byte> reader, object context);
    }
}