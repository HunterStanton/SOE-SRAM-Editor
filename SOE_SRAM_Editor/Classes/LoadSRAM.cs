using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SOE_SRAM_Editor
{
    /// <summary>
    /// Handles loading the SRAM file and grabbing information from it.
    /// </summary>
    class LoadSRAM
    {
        static public SRAM LoadSRAMFile(BinaryReader reader)
        {
            SRAM sram = new SRAM();
            
            // Read past the first two bytes of the SRAM file
            reader.ReadBytes(2);

            for(int i = 0;i < 4;i++)
            {
                sram.slot[i].sanity = reader.ReadUInt16();
                
                // Skip past the save location name
                reader.ReadBytes(0x24);

                sram.slot[i].boy.Name = Encoding.UTF8.GetString(reader.ReadBytes(36)).Split('\0')[0];
                sram.slot[i].dog.Name = Encoding.UTF8.GetString(reader.ReadBytes(36)).Split('\0')[0];
            }
            return sram;
        }
    }
}
