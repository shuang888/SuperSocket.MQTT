using System.Buffers;
using System.IO.Pipelines;
using System.Text;
using SuperSocket.ProtoBase;
using SuperSocket.Command;
using System.Threading.Tasks;

namespace SuperSocket.MQTT.Packets
{
    public class CONNECT : IAsyncCommand<ControlPacketType, MQTTPacket>
    {
        public ControlPacketType Key => throw new System.NotImplementedException();

        public string Name => throw new System.NotImplementedException();

        public Task ExecuteAsync(IAppSession session, MQTTPacket package)
        {
            throw new System.NotImplementedException();
        }
    }
}