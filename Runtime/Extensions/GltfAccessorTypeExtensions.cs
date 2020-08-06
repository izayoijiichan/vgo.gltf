// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Class     : GltfAccessorTypeExtensions
// ----------------------------------------------------------------------
namespace VgoGltf
{
    using System;

    /// <summary>
    /// glTF AccessorType Extensions
    /// </summary>
    public static class GltfAccessorTypeExtensions
    {
        /// <summary>
        /// Gets the number of elements in the accessor type.
        /// </summary>
        /// <param name="accessorType">The accessor type.</param>
        /// <returns>the number of elements in the accessor type.</returns>
        public static int TypeCount(this GltfAccessorType accessorType)
        {
            switch (accessorType)
            {
                case GltfAccessorType.SCALAR:
                    return 1;
                case GltfAccessorType.VEC2:
                    return 2;
                case GltfAccessorType.VEC3:
                    return 3;
                case GltfAccessorType.VEC4:
                    return 4;
                case GltfAccessorType.MAT2:
                    return 4;
                case GltfAccessorType.MAT3:
                    return 9;
                case GltfAccessorType.MAT4:
                    return 16;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
