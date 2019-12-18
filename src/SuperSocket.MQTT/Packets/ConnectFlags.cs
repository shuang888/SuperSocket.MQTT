using System;
using System.Buffers;
using SuperSocket.ProtoBase;

namespace SuperSocket.MQTT.Packets
{
    [Flags]
    public enum ConnectFlags : byte
    {
        Reserved = 1,
        CleanSession = 2,
        WillFlag = 4,
        WillQoS_L = 8,
        WillQoS_H = 16,
        WillRetain = 32,
        PasswordFlag = 64,
        UserNameFlag = 128
    }
}