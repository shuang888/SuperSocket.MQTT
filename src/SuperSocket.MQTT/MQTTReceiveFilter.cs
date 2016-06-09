using System;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT
{
    public class MQTTReceiveFilter : FixedHeaderReceiveFilter<MQTTPackageInfo>
    {
        public MQTTReceiveFilter(int headerSize)
            : base(2)
        {
            
        }

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