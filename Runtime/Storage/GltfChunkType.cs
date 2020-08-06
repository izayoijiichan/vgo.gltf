// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Class     : GltfChunkType
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>Chunk Type</summary>
    public enum GltfChunkType : uint
    {
        /// <summary>JSON</summary>
        /// <remarks>"JSON"</remarks>
        Json = 0x4E4F534A,
        /// <summary>BIN</summary>
        /// <remarks>"BIN "</remarks>
        Bin = 0x004E4942,
    }
}
