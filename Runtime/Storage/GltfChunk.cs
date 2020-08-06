// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Class     : GltfChunk
// ----------------------------------------------------------------------
namespace VgoGltf
{
    using System;
    using VgoGltf.Buffers;

    /// <summary>
    /// glTF Chunk
    /// </summary>
    public class GltfChunk
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of GltfChunk with chunkType and chunkData.
        /// </summary>
        /// <param name="chunkType"></param>
        /// <param name="chunkData"></param>
        public GltfChunk(GltfChunkType chunkType, IByteBuffer chunkData)
        {
            int paddingCount = CalculatePaddingCount(chunkData.Length, quotient: 4);

            ChunkLength = (uint)(chunkData.Length + paddingCount);
            ChunkType = chunkType;
            ChunkData = chunkData;
        }

        #endregion

        #region Fields

        /// <summary>Chunk Data Length</summary>
        public readonly uint ChunkLength = 0;

        /// <summary>Chunk Type</summary>
        public readonly GltfChunkType ChunkType;

        /// <summary>Chunk Data</summary>
        public readonly IByteBuffer ChunkData = default;

        #endregion

        #region Properties

        /// <summary>Chunk All Length</summary>
        public uint AllLength => 4 + 4 + ChunkLength;

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets ChunkData that has been padded.
        /// </summary>
        /// <returns></returns>
        public byte[] GetPaddingedData()
        {
            if (ChunkData == default)
            {
                return null;
            }

            int paddingCount = CalculatePaddingCount(ChunkData.Length, quotient: 4);

            byte[] bytes = new byte[ChunkData.Length + paddingCount];

            Array.Copy(ChunkData.ToArray(), bytes, ChunkData.Length);

            byte pad;

            if (ChunkType == GltfChunkType.Json)
            {
                pad = (byte)0x20;  // space
            }
            else
            {
                pad = (byte)0x00;
            }

            for (int i = ChunkData.Length - 1; i < paddingCount; i++)
            {
                bytes[i] = pad;
            }

            return bytes;
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Calculate the number of paddings.
        /// </summary>
        /// <param name="targetCount"></param>
        /// <param name="quotient"></param>
        /// <returns>The number of paddings.</returns>
        /// <remarks>
        /// When the quotient is 4, the padding is 0, 1, 2, 3.
        /// </remarks>
        protected int CalculatePaddingCount(int targetCount, int quotient)
        {
            int remainder = targetCount % quotient;

            int paddingCount = (remainder == 0) ? 0 : quotient - remainder;

            return paddingCount;
        }

        #endregion
    }
}
