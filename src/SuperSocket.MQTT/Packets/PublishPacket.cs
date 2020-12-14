using System;
using System.Buffers;
using System.Linq;
using System.Text;

namespace SuperSocket.MQTT.Packets
{
    public class PublishPacket : MQTTPacket
    {
        public int Qos { get; set; }
        public string TopicName { get; set; }
        public string TopicBody { get; set; }
        public ReadOnlyMemory<byte> TopicData { get; set; }
        public override int EncodeBody(IBufferWriter<byte> writer)
        {
            throw new System.NotImplementedException();
        }

        internal protected override void DecodeBody(ref SequenceReader<byte> reader, object context)
        {
            Qos = (this.Flags - 0x30) / 2;
            reader.TryReadBigEndian(out short protocolNameLen);
            TopicName = reader.ReadString(protocolNameLen, Encoding.UTF8);
            if (Qos > 0)
            {
                reader.TryRead(out byte msb);
                reader.TryRead(out byte lsb1);
                reader.TryPeek(out byte lsb2);
                if (lsb2 == 0)
                    reader.Advance(1);
            }
            TopicBody = reader.ReadString((int)reader.Remaining, Encoding.UTF8);
            TopicData = reader.Sequence.ToArray();
        }
    }
}