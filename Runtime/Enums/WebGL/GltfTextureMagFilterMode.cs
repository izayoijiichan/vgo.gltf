// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Enum      : GltfTextureMagFilterMode
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>Magnification filter mode.</summary>
    /// <remarks>WebGL.GLenum.TextureMagFilter</remarks>
    public enum GltfTextureMagFilterMode : uint
    {
        /// <summary></summary>
        NONE = 0x0000,
        /// <summary></summary>
        /// <remarks>9728</remarks>
        NEAREST = 0x2600,
        /// <summary></summary>
        /// <remarks>9729</remarks>
        LINEAR = 0x2601,
    }
}
