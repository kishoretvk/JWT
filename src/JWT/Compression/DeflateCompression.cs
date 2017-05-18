using System.IO;
using System.IO.Compression;
using System.Text;

namespace JWT.Compression
{
    class DeflateCompression : ICompression
    {
        public byte[] CompressData(byte[] inputText)
        {
            using (var ms = new MemoryStream())
            {
                using (var zip = new GZipStream(ms,
                                              CompressionMode.Compress))
                using (var writer = new StreamWriter(zip, Encoding.UTF8))
                {
                    writer.Write(inputText);
                }
                return ms.ToArray();

            }
        }

            public string UndoCompressData(byte[] compressedData)
            {
                using (var ms = new MemoryStream(compressedData))
                using (var zip = new GZipStream(ms, CompressionMode.Decompress))
                using (var sr = new StreamReader(zip, Encoding.UTF8))
                {
                    return sr.ReadToEnd();

                }

            }
        }
    }
