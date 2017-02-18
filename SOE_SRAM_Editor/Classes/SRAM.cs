using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOE_SRAM_Editor
{
    /// <summary>
    /// Class that represents the SRAM.
    /// This will get returned by the LoadSRAM class to the main window, where the UI will be populated with values from it.
    /// Then, when the user saves, it will take those values from UI, save them, and then commit them to file.
    /// </summary>
    class SRAM
    {
        // The 4 Save slots that can exist in an SRAM file
        public Save[] slots = new Save[4];

        /// <summary>
        /// Represents a single save slot
        /// </summary>
        public class Save
        {
            public Boy boy = new Boy();
            public Dog dog = new Dog();
            public Money money = new Money();
            public Weapons weapons = new Weapons();
            public Ingredients ingredients = new Ingredients();
            public Items items = new Items();
            public Armor armor = new Armor();
            public Helmet helmet = new Helmet();
            public Gauntlet gauntlet = new Gauntlet();
            public Collar collar = new Collar();
        }

        /// <summary>
        /// The Boys statistics
        /// </summary>
        public class Boy
        {
            public string Name;
            public int Level;
            public int Experience;
            public int HP; // HP at the time of the save. Max 999
        }

        /// <summary>
        /// The Dogs statistics
        /// </summary>
        public class Dog
        {
            public string Name;
            public int Level;
            public int Experience;
            public int HP; // HP at the time of the save. Max 999

            // Only Dog has this because Dog doesn't have switchable weapons
            public int AttackLevel;
            public int AttackXP; // How close the attack level is to the next level, values 0-99
        }

        /// <summary>
        /// The types of money that are possible to receive. Max 99,999,999
        /// </summary>
        public class Money
        {
            public int Talons; // Prehistoria
            public int Jewels; // Antiqua
            public int Coins; // Gothica
            public int Credits; // Omnitopia
        }
        
        /// <summary>
        /// Weapons the boy can wield
        /// </summary>
        public class Weapons
        {
            public bool HasBoneCrusher;
            public int BoneCrusherLevel;
            public int BoneCrusherXP;
            public bool HasSpidersClaw;
            public int SpidersClawLevel;
            public int SpidersClawXP;
            public bool HasHornedSpear;
            public int HornedSpearLevel;
            public int HornedSpearXP;
            public bool HasGladiatorSword;
            public int GladiatorSwordLevel;
            public int GladiatorSwordXP;
            public bool HasBronzeAxe;
            public int BronzeAxeLevel;
            public int BronzeAxeXP;
            public bool HasBronzeSpear;
            public int BronzeSpearLevel;
            public int BronzeSpearXP;
            public bool HasCrusaderSword;
            public int CrusaderSwordLevel;
            public int CrusaderSwordXP;
            public bool HasKnightBasher;
            public int KnightBasherLevel;
            public int KnightBasherXP;
            public bool HasLance;
            public int LanceLevel;
            public int LanceXP;
            public bool HasNeutronBlade;
            public int NeutronBladeLevel;
            public int NeutronBladeXP;
            public bool HasAtomSmasher;
            public int AtomSmasherLevel;
            public int AtomSmasherXP;
            public bool HasLaserLance;
            public int LaserLanceLevel;
            public int LaserLanceXP;
            public bool HasBazooka;
            public int ThunderBallAmmo;
            public int ParticleBombAmmo;
            public int CryoBlastAmmo;
        }

        /// <summary>
        /// Alchemy ingredients. Max 99 normally, but can be forced higher
        /// </summary>
        public class Ingredients
        {
            public int Acorn;
            public int Ash;
            public int AtlasMedallion;
            public int Bone;
            public int Brimstone;
            public int Clay;
            public int Crystal;
            public int DryIce;
            public int Ethanol;
            public int Feather;
            public int Grease;
            public int Gunpowder;
            public int Iron;
            public int Limestone;
            public int Meteorite;
            public int MudPepper;
            public int Mushroom;
            public int Oil;
            public int Root;
            public int Vinegar;
            public int Water;
            public int Wax;
        }

        /// <summary>
        /// Consumable items that can be bought/found/dropped. Max 6 normally, but can be forced higher.
        /// </summary>
        public class Items
        {
            public int Petal;
            public int Nectar;
            public int Honey;
            public int DogBiscuit;
            public int Wings;
            public int Essence;
            public int PixieDust;
            public int CallBeads;
        }

        /// <summary>
        /// Chest piece items that boost defense. Max 6 normally, but can be forced higher.
        /// </summary>
        public class Armor
        {
            public int GrassVest;
            public int ShellPlate;
            public int DinoSkin;
            public int BronzeArmor;
            public int StoneVest;
            public int CenturionCape;
            public int SilverMail;
            public int GoldPlatedVest;
            public int ShiningArmor;
            public int MagnaMail;
            public int TitaniumVest;
            public int VirtualVest;
        }

        /// <summary>
        /// Helmet piece items that boost defense. Max 6 normally, but can be forced higher.
        /// </summary>
        public class Helmet
        {
            public int GrassHat;
            public int ShellHat;
            public int DinoHelm;
            public int BronzeHelmet;
            public int ObsidianHelm;
            public int CenturionHelm;
            public int TitansCrown;
            public int DragonHelm;
            public int KnightsHelm;
            public int LightningHelm;
            public int OldReliable;
            public int Brainstorm;
        }

        /// <summary>
        /// Gauntlet piece items that boost defense. Max 6 normally, but can be forced higher.
        /// </summary>
        public class Gauntlet
        {
            public int VineBracelet;
            public int MammothGuard;
            public int ClawGuard;
            public int SerpentBracer;
            public int BronzeGauntlet;
            public int GlovesOfRa;
            public int IronBracer;
            public int MagiciansRing;
            public int DragonsClaw;
            public int Cyberglove;
            public int ProtectorRing;
            public int VirtualGlove;
        }

        /// <summary>
        /// Collars that dog can wear that boost dog's defense. Max 6 normally, but can be forced higher.
        /// </summary>
        public class Collar
        {
            public int LeatherCollar;
            public int SpikyCollar;
            public int DefenderCollar;
            public int SpotsCollar;
        }
    }
}
