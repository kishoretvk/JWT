using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JWT.Compression
{
   public interface ICompression
    {
        /// <summary>
        /// interface to get data compression, response compression 
        /// </summary>
        /// <param name="inputText">The data to compress.</param>
       /// <param name="compressedData">The data to de compressed.</param>
        /// <returns></returns>
        byte[] CompressData(byte[] inputText);
        string UndoCompressData(byte[] compressedData);
    }
}
