using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SOE_SRAM_Editor
{
    public static class BinaryReaderAddon
    {
        
        /// <summary>
        /// Reads 3 bytes/24 bits from the stream and returns an int.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static int ReadInt24(this BinaryReader reader)
        {
            byte[] data = reader.ReadBytes(3);
            return data[0] + (data[1] << 8) + (data[2] << 16);
        }

        /// <summary>
        /// Reads 3 bytes/24 bits from the stream and returns a uint.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static uint ReadUInt24(this BinaryReader reader)
        {
            return BitConverter.ToUInt32(reader.ReadBytes(3), 0);
        }
    }
}
