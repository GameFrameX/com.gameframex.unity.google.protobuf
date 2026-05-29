using GameFrameX.Network.Runtime;
using ProtoBuf.Meta;

namespace ProtoBuf
{
    [UnityEngine.Scripting.Preserve]
    public static class ProtobufSerializerInitializer
    {
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Initialize()
        {
            RegisterMessageHttpObject();
            MessageSerializerRegistry.RegisterGlobal(new ProtobufMessageSerializer());
        }

        private static void RegisterMessageHttpObject()
        {
            var model = RuntimeTypeModel.Default;
            var type = typeof(MessageHttpObject);
            if (model.CanSerialize(type))
            {
                return;
            }
            var metaType = model.Add(type, false);
            metaType.Add(1, nameof(MessageHttpObject.Id));
            metaType.Add(2, nameof(MessageHttpObject.UniqueId));
            metaType.Add(3, nameof(MessageHttpObject.Body));
        }
    }
}
