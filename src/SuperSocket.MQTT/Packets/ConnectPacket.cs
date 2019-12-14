using System.Buffers;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT.Packets
{
    public class ConnectPacket : MQTTPacket
    {
        internal protected override void DecodeBody(ref SequenceReader<byte> reader, object context)
        {
            
        }
    }
}