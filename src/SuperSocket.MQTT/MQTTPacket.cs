using System.Buffers;
using System.IO.Pipelines;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT
{
    public abstract class MQTTPacket
    {
        public ControlPacketType Type { get; set; }

        public byte Flags { get; set; }
        
        internal protected abstract void DecodeBody(ref SequenceReader<byte> reader, object context);

        public abstract int EncodeBody(PipeWriter writer);
    }
}