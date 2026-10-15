using GameFrameX.Network.Runtime;

namespace ProtoBuf
{
    /// <summary>
    /// Protobuf 序列化器自动初始化器，在 Unity 运行时加载时将 <see cref="ProtobufMessageSerializer"/> 注册为全局默认。
    /// </summary>
    /// <remarks>
    /// Protobuf serializer auto-initializer that registers <see cref="ProtobufMessageSerializer"/> as the global default on Unity runtime load.
    /// </remarks>
    [UnityEngine.Scripting.Preserve]
    public static class ProtobufSerializerInitializer
    {
        /// <summary>
        /// 初始化 Protobuf 序列化器并注册为全局默认消息序列化器。
        /// </summary>
        /// <remarks>
        /// Initializes the Protobuf serializer and registers it as the global default message serializer.
        /// </remarks>
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Initialize()
        {
            MessageSerializerRegistry.RegisterGlobal(new ProtobufMessageSerializer());
        }
    }
}
