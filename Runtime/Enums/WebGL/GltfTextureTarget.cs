// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Enum      : GltfTextureTarget
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary></summary>
    public enum GltfTextureTarget : uint
    {
        /// <summary></summary>
        TEXTURE_2D = 0x0DE1,
        /// <summary></summary>
        TEXTURE = 0x2801,
        /// <summary></summary>
        TEXTURE_CUBE_MAP = 0x8513,
        /// <summary></summary>
        TEXTURE_BINDING_CUBE_MAP = 0x8514,
        /// <summary></summary>
        TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515,
        /// <summary></summary>
        TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516,
        /// <summary></summary>
        TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517,
        /// <summary></summary>
        TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518,
        /// <summary></summary>
        TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519,
        /// <summary></summary>
        TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A,
        /// <summary></summary>
        MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C,
    }
}
