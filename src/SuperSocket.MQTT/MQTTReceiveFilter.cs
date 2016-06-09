using System;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT
{
    public class MQTTPackageInfo : FixedHeaderReceiveFilter<MQTTPackageInfo>
    {
        public override MQTTPackageInfo ResolvePackage(IBufferStream bufferStream)
        {
            throw new NotImplementedException();
        }

        protected override int GetBodyLengthFromHeader(IBufferStream bufferStream, int length)
        {
            throw new NotImplementedException();
        }
    }
}