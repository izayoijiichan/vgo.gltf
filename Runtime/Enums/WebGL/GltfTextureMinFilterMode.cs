// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Enum      : GltfTextureMinFilterMode
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>Minification filter mode.</summary>
    /// <remarks>WebGL.GLenum.TextureMinFilter</remarks>
    public enum GltfTextureMinFilterMode : uint
    {
        /// <summary></summary>
        NONE = 0x0000,
        /// <summary></summary>
        /// <remarks>9728</remarks>
        NEAREST = 0x2600,
        /// <summary></summary>
        /// <remarks>9729</remarks>
        LINEAR = 0x2601,
        /// <summary></summary>
        /// <remarks>9984</remarks>
        NEAREST_MIPMAP_NEAREST = 0x2700,
        /// <summary></summary>
        /// <remarks>9985</remarks>
        LINEAR_MIPMAP_NEAREST = 0x2701,
        /// <summary></summary>
        /// <remarks>9986</remarks>
        NEAREST_MIPMAP_LINEAR = 0x2702,
        /// <summary></summary>
        /// <remarks>9987</remarks>
        LINEAR_MIPMAP_LINEAR = 0x2703,
    }
}
