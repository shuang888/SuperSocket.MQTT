using System.Buffers;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT.Packets
{
    public class ConnAckPacket : MQTTPacket
    {
        internal protected override void DecodeBody(ref SequenceReader<byte> reader, object context)
        {
            
        }
    }
}