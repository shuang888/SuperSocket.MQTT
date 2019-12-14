using System;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT
{
    public class MQTTPipelineFilter : FixedHeaderPipelineFilter<MQTTPackage>
    {
        public MQTTPipelineFilter(int headerSize)
            : base(2)
        {
            
        }
    }
}