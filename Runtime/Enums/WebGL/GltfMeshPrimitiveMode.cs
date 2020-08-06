// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Enum      : GltfMeshPrimitiveMode
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>The type of primitives to render.</summary>
    /// <remarks>WebGL.GLenum.BeginMode</remarks>
    public enum GltfMeshPrimitiveMode : uint
    {
        /// <summary></summary>
        POINTS = 0x0000,
        /// <summary></summary>
        LINES = 0x0001,
        /// <summary></summary>
        LINE_LOOP = 0x0002,
        /// <summary></summary>
        LINE_STRIP = 0x0003,
        /// <summary></summary>
        TRIANGLES = 0x0004,
        /// <summary></summary>
        TRIANGLE_STRIP = 0x0005,
        /// <summary></summary>
        TRIANGLE_FAN = 0x0006,
    }
}
