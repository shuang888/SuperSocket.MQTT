using System.Buffers;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT
{
    public abstract class MQTTPacket : IKeyedPackageInfo<ControlPacketType>
    {
        public ControlPacketType Type { get; set; }

        public byte Flags { get; set; }

        ControlPacketType IKeyedPackageInfo<ControlPacketType>.Key => Type;

        internal protected abstract void DecodeBody(ref SequenceReader<byte> reader, object context);

        public abstract int EncodeBody(IBufferWriter<byte> writer);
    }
}