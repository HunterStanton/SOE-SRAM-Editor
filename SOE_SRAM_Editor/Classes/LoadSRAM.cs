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

                // Once again divide by 2.65 to get the proper XP/minor level
                sram.slot[i].dog.AttackXP = Convert.ToInt32(reader.ReadByte() / 2.65);
                sram.slot[i].dog.AttackLevel = reader.ReadByte();

                reader.ReadBytes(0x16);

                sram.slot[i].alchemy.AcidRainXP = reader.ReadInt16();
                sram.slot[i].alchemy.AtlasXP = reader.ReadInt16();
                sram.slot[i].alchemy.BarrierXP = reader.ReadInt16();
                sram.slot[i].alchemy.CallUpXP = reader.ReadInt16();
                sram.slot[i].alchemy.CorrosionXP = reader.ReadInt16();
                sram.slot[i].alchemy.CrushXP = reader.ReadInt16();
                sram.slot[i].alchemy.CureXP = reader.ReadInt16();
                sram.slot[i].alchemy.DefendXP = reader.ReadInt16();
                sram.slot[i].alchemy.DoubleDrainXP = reader.ReadInt16();
                sram.slot[i].alchemy.DrainXP = reader.ReadInt16();
                sram.slot[i].alchemy.EnergizeXP = reader.ReadInt16();
                sram.slot[i].alchemy.EscapeXP = reader.ReadInt16();
                sram.slot[i].alchemy.ExplosionXP = reader.ReadInt16();
                sram.slot[i].alchemy.FireballXP = reader.ReadInt16();
                sram.slot[i].alchemy.FirePowerXP = reader.ReadInt16();
                sram.slot[i].alchemy.FlashXP = reader.ReadInt16();
                sram.slot[i].alchemy.ForceFieldXP = reader.ReadInt16();
                sram.slot[i].alchemy.HardBallXP = reader.ReadInt16();
                sram.slot[i].alchemy.HealXP = reader.ReadInt16();
                sram.slot[i].alchemy.LanceXP = reader.ReadInt16();

                // XP for the unused alchemy formula, Laser. Can't get it legitimately and it does nothing, but its still here
                reader.ReadInt16();

                sram.slot[i].alchemy.LevitateXP = reader.ReadInt16();
                sram.slot[i].alchemy.LightningStormXP = reader.ReadInt16();
                sram.slot[i].alchemy.MiracleCureXP = reader.ReadInt16();
                sram.slot[i].alchemy.NitroXP = reader.ReadInt16();
                sram.slot[i].alchemy.OneUpXP = reader.ReadInt16();
                sram.slot[i].alchemy.ReflectXP = reader.ReadInt16();
                sram.slot[i].alchemy.RegrowthXP = reader.ReadInt16();
                sram.slot[i].alchemy.RevealerXP = reader.ReadInt16();
                sram.slot[i].alchemy.ReviveXP = reader.ReadInt16();
                sram.slot[i].alchemy.SlowBurnXP = reader.ReadInt16();
                sram.slot[i].alchemy.SpeedXP = reader.ReadInt16();
                sram.slot[i].alchemy.StingXP = reader.ReadInt16();
                sram.slot[i].alchemy.StopXP = reader.ReadInt16();
                sram.slot[i].alchemy.SuperHealXP = reader.ReadInt16();

                sram.slot[i].alchemy.AcidRainLevel = reader.ReadInt16();
                sram.slot[i].alchemy.AtlasLevel = reader.ReadInt16();
                sram.slot[i].alchemy.BarrierLevel = reader.ReadInt16();
                sram.slot[i].alchemy.CallUpLevel = reader.ReadInt16();
                sram.slot[i].alchemy.CorrosionLevel = reader.ReadInt16();
                sram.slot[i].alchemy.CrushLevel = reader.ReadInt16();
                sram.slot[i].alchemy.CureLevel = reader.ReadInt16();
                sram.slot[i].alchemy.DefendLevel = reader.ReadInt16();
                sram.slot[i].alchemy.DoubleDrainLevel = reader.ReadInt16();
                sram.slot[i].alchemy.DrainLevel = reader.ReadInt16();
                sram.slot[i].alchemy.EnergizeLevel = reader.ReadInt16();
                sram.slot[i].alchemy.EscapeLevel = reader.ReadInt16();
                sram.slot[i].alchemy.ExplosionLevel = reader.ReadInt16();
                sram.slot[i].alchemy.FireballLevel = reader.ReadInt16();
                sram.slot[i].alchemy.FirePowerLevel = reader.ReadInt16();
                sram.slot[i].alchemy.FlashLevel = reader.ReadInt16();
                sram.slot[i].alchemy.ForceFieldLevel = reader.ReadInt16();
                sram.slot[i].alchemy.HardBallLevel = reader.ReadInt16();
                sram.slot[i].alchemy.HealLevel = reader.ReadInt16();
                sram.slot[i].alchemy.LanceLevel = reader.ReadInt16();

                // Level for the unused alchemy formula, Laser. Can't get it legitimately and it does nothing, but its still here
                reader.ReadInt16();

                sram.slot[i].alchemy.LevitateLevel = reader.ReadInt16();
                sram.slot[i].alchemy.LightningStormLevel = reader.ReadInt16();
                sram.slot[i].alchemy.MiracleCureLevel = reader.ReadInt16();
                sram.slot[i].alchemy.NitroLevel = reader.ReadInt16();
                sram.slot[i].alchemy.OneUpLevel = reader.ReadInt16();
                sram.slot[i].alchemy.ReflectLevel = reader.ReadInt16();
                sram.slot[i].alchemy.RegrowthLevel = reader.ReadInt16();
                sram.slot[i].alchemy.RevealerLevel = reader.ReadInt16();
                sram.slot[i].alchemy.ReviveLevel = reader.ReadInt16();
                sram.slot[i].alchemy.SlowBurnLevel = reader.ReadInt16();
                sram.slot[i].alchemy.SpeedLevel = reader.ReadInt16();
                sram.slot[i].alchemy.StingLevel = reader.ReadInt16();
                sram.slot[i].alchemy.StopLevel = reader.ReadInt16();
                sram.slot[i].alchemy.SuperHealLevel = reader.ReadInt16();


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

        /// <summary>
        /// The bits that represent if the user has the first set of alchemy formulas.
        /// </summary>
        [Flags]
        public enum Alchemy1 : byte
        {
            AcidRain = 1 << 0,
            Atlas = 1 << 1,
            Barrier = 1 << 2,
            CallUp = 1 << 3,
            Corrosion = 1 << 4,
            Crush = 1 << 5,
            Cure = 1 << 6,
            Defend = 1 << 7,
        }

        /// <summary>
        /// The bits that represent if the user has the second set of alchemy formulas.
        /// </summary>
        [Flags]
        public enum Alchemy2 : byte
        {
            DoubleDrain = 1 << 0,
            Drain = 1 << 1,
            Energize = 1 << 2,
            Escape = 1 << 3,
            Explosion = 1 << 4,
            Fireball = 1 << 5,
            FirePower = 1 << 6,
            Flash = 1 << 7,
        }

        /// <summary>
        /// The bits that represent if the user has the third set of alchemy formulas.
        /// </summary>
        [Flags]
        public enum Alchemy3 : byte
        {
            ForceField = 1 << 0,
            Hardball = 1 << 1,
            Heal = 1 << 2,
            Lance = 1 << 3,
            Laser = 1 << 4,
            Levitate = 1 << 5,
            LightningStorm = 1 << 6,
            MiracleCure = 1 << 7,
        }

        /// <summary>
        /// The bits that represent if the user has the forth set of alchemy formulas.
        /// </summary>
        [Flags]
        public enum Alchemy4 : byte
        {
            Nitro = 1 << 0,
            OneUp = 1 << 1,
            Reflect = 1 << 2,
            Regrowth = 1 << 3,
            Revealer = 1 << 4,
            Revive = 1 << 5,
            SlowBurn = 1 << 6,
            Speed = 1 << 7,
        }

        /// <summary>
        /// The bits that represent if the user has the fifth set of alchemy formulas.
        /// </summary>
        [Flags]
        public enum Alchemy5 : byte
        {
            Sting = 1 << 0,
            Stop = 1 << 1,
            SuperHeal = 1 << 2
        }
    }

}
