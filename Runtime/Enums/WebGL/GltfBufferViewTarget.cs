// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Enum      : GltfBufferViewTarget
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>The target that the GPU buffer should be bound to.</summary>
    /// <remarks>WebGL.GLenum.BufferObjects</remarks>
    public enum GltfBufferViewTarget : uint
    {
        /// <summary></summary>
        NONE = 0x0000,
        /// <summary></summary>
        /// <remarks>34962</remarks>
        ARRAY_BUFFER = 0x8892,
        /// <summary></summary>
        /// <remarks>34963</remarks>
        ELEMENT_ARRAY_BUFFER = 0x8893,
        ///// <summary></summary>
        ///// <remarks>34964</remarks>
        //ARRAY_BUFFER_BINDING = 0x8894,
        ///// <summary></summary>
        ///// <remarks>34965</remarks>
        //ELEMENT_ARRAY_BUFFER_BINDING = 0x8895,
    }
}
