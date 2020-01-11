using System.Buffers;
using System.IO.Pipelines;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT.Packets
{
    public class PublishPacket : MQTTPacket
    {
        public override int EncodeBody(PipeWriter writer)
        {
            throw new System.NotImplementedException();
        }

        internal protected override void DecodeBody(ref SequenceReader<byte> reader, object context)
        {
            
        }
    }
}