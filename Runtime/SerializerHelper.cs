using System.IO;
using ProtoBuf.Meta;

namespace ProtoBuf
{
    public static class SerializerHelper
    {
        public static byte[] Serialize<T>(T value)
        {
            using (var memoryStream = new MemoryStream())
            {
                RuntimeTypeModel.Default.Serialize(memoryStream, value);
                return memoryStream.ToArray();
            }
        }

        public static T Deserialize<T>(byte[] data)
        {
            using (var memoryStream = new MemoryStream(data))
            {
                return (T)RuntimeTypeModel.Default.Deserialize(memoryStream, null, typeof(T));
            }
        }
    }
}