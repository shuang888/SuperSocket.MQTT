using System.Buffers;
using System.IO.Pipelines;
using System.Text;
using SuperSocket.ProtoBase;
using SuperSocket.Command;
using System.Threading.Tasks;
using System;

namespace SuperSocket.MQTT.Packets
{
    [Command(Key = ControlPacketType.CONNECT)]
    public class CONNECT : IAsyncCommand<MQTTPacket>
    {
        public async ValueTask ExecuteAsync(IAppSession session, MQTTPacket package)
        {
            var ConnectPacket = package as ConnectPacket;
            await session.SendAsync(new byte[] { 32, 2, 0, 0 });
        }
    }
}