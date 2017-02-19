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
                // Always make sure we come back to the beginning of the next save slot before reading
                reader.BaseStream.Position = 2 + ((i) * 0x331);

                // Theres honestly not a whole lot of point in reading this, we always recalculate it and don't show it in UI
                sram.slot[i].sanity = reader.ReadUInt16();

                sram.slot[i].location = Encoding.UTF8.GetString(reader.ReadBytes(0x24)).Split('\0')[0];

                sram.slot[i].boy.Name = Encoding.UTF8.GetString(reader.ReadBytes(36)).Split('\0')[0];
                sram.slot[i].dog.Name = Encoding.UTF8.GetString(reader.ReadBytes(36)).Split('\0')[0];

                sram.slot[i].boy.HP = reader.ReadUInt16();
                reader.ReadBytes(0x1e);
                sram.slot[i].boy.MaxHP = reader.ReadUInt16();
                reader.ReadBytes(0xa);

                sram.slot[i].boy.Experience = reader.ReadInt24();
            }
            return sram;
        }
    }
}
