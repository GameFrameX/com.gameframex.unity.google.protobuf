using System;
using GameFrameX.Network.Runtime;

namespace ProtoBuf
{
    /// <summary>
    /// 基于 protobuf-net 的 <see cref="IMessageSerializer"/> 实现。
    /// </summary>
    /// <remarks>
    /// <see cref="IMessageSerializer"/> implementation based on protobuf-net.
    /// </remarks>
    [UnityEngine.Scripting.Preserve]
    public class ProtobufMessageSerializer : IMessageSerializer
    {
        /// <summary>
        /// 将消息对象序列化为字节数组。
        /// </summary>
        /// <remarks>
        /// Serializes a message object to a byte array.
        /// </remarks>
        /// <param name="message">要序列化的消息对象 / The message object to serialize</param>
        /// <returns>序列化后的字节数组 / The serialized byte array</returns>
        public byte[] Serialize<T>(T message) where T : MessageObject
        {
            return SerializerHelper.Serialize(message);
        }

        /// <summary>
        /// 将字节数组反序列化为指定类型的消息对象。
        /// </summary>
        /// <remarks>
        /// Deserializes a byte array into a message object of the specified type.
        /// </remarks>
        /// <param name="data">要反序列化的字节数组 / The byte array to deserialize</param>
        /// <param name="targetType">目标消息类型 / The target message type</param>
        /// <returns>反序列化后的消息对象 / The deserialized message object</returns>
        public object Deserialize(byte[] data, Type targetType)
        {
            return SerializerHelper.Deserialize(data, targetType);
        }
    }
}
