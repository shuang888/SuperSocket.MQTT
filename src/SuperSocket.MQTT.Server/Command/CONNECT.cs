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
            //Return code:
            //0x00 Connection accepted
            //0x01 Connection refused, protocol version not supported
            //0x02 Connection refused, unqualified client identifier
            //0x03 Connection refused, server is unavailable
            //0x04 Connection refused, invalid username or password
            await session.SendAsync(new byte[] { 32, 2, 0, 0 });
        }
    }
}