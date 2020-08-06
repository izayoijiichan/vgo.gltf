// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Class     : GltfHeader
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>
    /// glTF Header
    /// </summary>
    public struct GltfHeader
    {
        #region Fields

        /// <summary>Magic</summary>
        public uint Magic;

        /// <summary>Version</summary>
        public uint Version;

        /// <summary>Length</summary>
        public uint Length;

        #endregion
    }
}
