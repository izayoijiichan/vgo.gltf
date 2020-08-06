// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Class     : GltfComponentTypeExtensions
// ----------------------------------------------------------------------
namespace VgoGltf
{
    using System;

    /// <summary>
    /// glTF ComponentType Extensions
    /// </summary>
    public static class GltfComponentTypeExtensions
    {
        /// <summary>
        /// Gets the byte size of the component type.
        /// </summary>
        /// <param name="componentType">The component type.</param>
        /// <returns>The byte size of the component type.</returns>
        public static int ByteSize(this GltfComponentType componentType)
        {
            switch (componentType)
            {
                case GltfComponentType.BYTE:
                case GltfComponentType.UNSIGNED_BYTE:
                    return 1;
                case GltfComponentType.SHORT:
                case GltfComponentType.UNSIGNED_SHORT:
                    return 2;
                case GltfComponentType.INT:
                case GltfComponentType.UNSIGNED_INT:
                case GltfComponentType.FLOAT:
                    return 4;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
