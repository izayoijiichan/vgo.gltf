// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Enum      : GltfAlphaMode
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>The alpha mode.</summary>
    public enum GltfAlphaMode
    {
        /// <summary>The alpha value is ignored and the rendered output is fully opaque.</summary>
        OPAQUE = 0,
        /// <summary>The rendered output is either fully opaque or fully transparent depending on the alpha value and the specified alpha cutoff value.</summary>
        MASK,
        /// <summary>The alpha value is used to composite the source and destination areas.</summary>
        /// <remarks>The rendered output is combined with the background using the normal painting operation (i.e. the Porter and Duff over operator).</remarks>
        BLEND,
        /// <summary>MToon</summary>
        BLEND_ZWRITE,
    }
}
