// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Enum      : GltfAnimationInterpolationType
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>Interpolation algorithm.</summary>
    public enum GltfAnimationInterpolationType
    {
        /// <summary>The animated values are linearly interpolated between keyframes.</summary>
        /// <remarks>
        /// When targeting a rotation, spherical linear interpolation (slerp) should be used to interpolate quaternions.
        /// The number output of elements must equal the number of input elements.
        /// </remarks>
        LINEAR,
        /// <summary>The animated values remain constant to the output of the first keyframe, until the next keyframe.</summary>
        /// <remarks>The number of output elements must equal the number of input elements.</remarks>
        STEP,
        /// <summary>The animation's interpolation is computed using a cubic spline with specified tangents.</summary>
        /// <remarks>
        /// The number of output elements must equal three times the number of input elements.
        /// For each input element, the output stores three elements, an in-tangent, a spline vertex, and an out-tangent.
        /// There must be at least two keyframes when using this interpolation.
        /// </remarks>
        CUBICSPLINE,
    }
}
