using System;
using GameFrameX.Network.Runtime;

namespace ProtoBuf
{
    [UnityEngine.Scripting.Preserve]
    public class ProtobufMessageSerializer : IMessageSerializer
    {
        public byte[] Serialize<T>(T message) where T : MessageObject
        {
            return SerializerHelper.Serialize(message);
        }

        public object Deserialize(byte[] data, Type targetType)
        {
            return SerializerHelper.Deserialize(data, targetType);
        }
    }
}
