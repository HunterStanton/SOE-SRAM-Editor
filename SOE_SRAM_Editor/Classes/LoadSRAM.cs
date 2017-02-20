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

                // Read boy stats
                sram.slot[i].boy.HP = reader.ReadUInt16();
                reader.ReadBytes(0x1e);
                sram.slot[i].boy.MaxHP = reader.ReadUInt16();
                reader.ReadBytes(0xa);
                sram.slot[i].boy.Experience = reader.ReadInt24();
                sram.slot[i].boy.Level = reader.ReadByte();
                reader.ReadBytes(0x11);

                // Read dog stats
                sram.slot[i].dog.HP = reader.ReadUInt16();
                reader.ReadBytes(0x1e);
                sram.slot[i].dog.MaxHP = reader.ReadUInt16();
                reader.ReadBytes(0xa);
                sram.slot[i].dog.Experience = reader.ReadInt24();
                sram.slot[i].dog.Level = reader.ReadByte();

                reader.ReadBytes(0x1d);

                // Read money
                sram.slot[i].money.Talons = reader.ReadInt24();
                sram.slot[i].money.Jewels = reader.ReadInt24();
                sram.slot[i].money.Coins = reader.ReadInt24();
                sram.slot[i].money.Credits = reader.ReadInt24();

                reader.ReadBytes(0xd);

                // Divide by 2.65 to get the proper XP/minor level
                sram.slot[i].weapons.BoneCrusherXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.BoneCrusherLevel = reader.ReadByte();
                sram.slot[i].weapons.GladiatorSwordXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.GladiatorSwordLevel = reader.ReadByte();
                sram.slot[i].weapons.CrusaderSwordXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.CrusaderSwordLevel = reader.ReadByte();
                sram.slot[i].weapons.NeutronBladeXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.NeutronBladeLevel = reader.ReadByte();
                sram.slot[i].weapons.SpidersClawXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.SpidersClawLevel = reader.ReadByte();
                sram.slot[i].weapons.BronzeAxeXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.BronzeAxeLevel = reader.ReadByte();
                sram.slot[i].weapons.KnightBasherXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.KnightBasherLevel = reader.ReadByte();
                sram.slot[i].weapons.AtomSmasherXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.AtomSmasherLevel = reader.ReadByte();
                sram.slot[i].weapons.HornedSpearXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.HornedSpearLevel = reader.ReadByte();
                sram.slot[i].weapons.BronzeSpearXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.BronzeSpearLevel = reader.ReadByte();
                sram.slot[i].weapons.LanceXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.LanceLevel = reader.ReadByte();
                sram.slot[i].weapons.LaserLanceXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].weapons.LaserLanceLevel = reader.ReadByte();

                reader.ReadBytes(0x10);

                sram.slot[i].dog.AttackXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].dog.AttackLevel = reader.ReadByte();


            }
            return sram;
        }

        /// <summary>
        /// The bits that represent if the user has the first half of weapons.
        /// </summary>
        [Flags]
        public enum WeaponByte1 : byte
        {
            BoneCrusher = 1 << 1,
            GladiatorSword = 1 << 2,
            CrusaderSword = 1 << 3,
            NeutronBlade = 1 << 4,
            SpidersClaw = 1 << 5,
            BronzeAxe = 1 << 6,
            KnightBasher = 1 << 7

        }

        /// <summary>
        /// The bits that represent if the user has the second half of weapons.
        /// </summary>
        [Flags]
        public enum WeaponByte2 : byte
        {
            AtomSmasher = 1 << 0,
            HornedSpear = 1 << 1,
            BronzeSpear = 1 << 2,
            Lance = 1 << 3,
            LaserLance = 1 << 4,
            Bazooka = 1 << 5
        }
    }

}
