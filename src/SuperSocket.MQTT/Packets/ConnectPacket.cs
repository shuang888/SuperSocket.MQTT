using System.Buffers;
using System.Text;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT.Packets
{
    public class ConnectPacket : MQTTPacket
    {
        public string ProtocolName { get; private set; }

        public int ProtocolLevel { get; private set; }

        public short KeepAlive { get; private set; }

        public string ClientId { get; private set; }

        internal protected override void DecodeBody(ref SequenceReader<byte> reader, object context)
        {
            reader.TryReadBigEndian(out short protocolNameLen);
            ProtocolName = reader.ReadString(protocolNameLen, Encoding.ASCII);

            reader.TryRead(out byte protocolLevel);
            ProtocolLevel = protocolLevel;

            reader.TryRead(out byte flags);
            Flags = flags;

            reader.TryReadBigEndian(out short keepAlive);
            KeepAlive = keepAlive;
        }
    }
}