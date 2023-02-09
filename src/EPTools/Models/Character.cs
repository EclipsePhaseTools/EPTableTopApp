namespace EPTools.Models
{
    public class Character
    {
        //General Information
        #region General Information
        public string Name { get; set; } = String.Empty;
        public string Aliases { get; set; } = String.Empty;
        public string Background { get; set; } = String.Empty;
        public string Career { get; set; } = String.Empty;
        public string Interest { get; set; } = String.Empty;
        public string Faction { get; set; } = String.Empty;
        public string Languages { get; set; } = String.Empty;
        public string Motivations { get; set; } = String.Empty;
        public string DiscordHook { get; set; } = String.Empty;
        #endregion

        //Fork Information
        #region Fork Information
        public List<Character> Forks { get; set; } = new List<Character>();
        public bool IsPrimeEgo { get; set; }
        #endregion

        //Ego Stats
        #region Ego Stats
        public int Lucidity => (WillpowerBaseRank * 2) + LucidityBonus;
        public int LucidityBonus { get; set; }
        public int TraumaThreshold => (Lucidity / 5) + TraumaThresholdBonus;
        public int TraumaThresholdBonus { get; set; }
        public int InsanityRating => (Lucidity * 2) + InsanityRatingBonus;
        public int InsanityRatingBonus { get; set; }
        public int Stress { get; set; }
        public int Traumas { get; set; }
        public int Initiative => ((ReflexesBaseRank + IntuitionBaseRank) / 5) + InitiativeBonus;
        public int InitiativeBonus { get; set; }
        public int RezPoints { get; set; }
        public int SpentRezPoints { get; set; }
        #endregion

        //Morph Stats
        public CharacterMorph Morph { get; set; } = new CharacterMorph();

        //Aptitudes
        #region Aptitudes
        public int CognitionBaseRank { get; set; }
        public int CognitionCheckMod { get; set; }
        public int CognitionCheckTotal => (CognitionBaseRank * 3) + CognitionCheckMod;
        public int IntuitionBaseRank { get; set; }
        public int IntuitionCheckMod { get; set; }
        public int IntuitionCheckTotal => (IntuitionBaseRank * 3) + IntuitionCheckMod;
        public int ReflexesBaseRank { get; set; }
        public int ReflexesCheckMod { get; set; }
        public int ReflexesCheckTotal => (ReflexesBaseRank * 3) + ReflexesCheckMod;
        public int SavvyBaseRank { get; set; }
        public int SavvyCheckMod { get; set; }
        public int SavvyCheckTotal => (SavvyBaseRank * 3) + SavvyCheckMod;
        public int SomaticsBaseRank { get; set; }
        public int SomaticsCheckMod { get; set; }
        public int SomaticsCheckTotal => (SomaticsBaseRank * 3) + SomaticsCheckMod;
        public int WillpowerBaseRank { get; set; }
        public int WillpowerCheckMod { get; set; }
        public int WillpowerCheckTotal => (WillpowerBaseRank * 3) + WillpowerCheckMod;
        #endregion

        public List<CharacterSkill> CharacterSkills { get; set; } = new List<CharacterSkill>();
        public List<CharacterGear> CharacterGear { get; set; } = new List<CharacterGear>();

        public List<CharacterGearCache> CharacterGearCache { get; set; } = new List<CharacterGearCache>();

        public List<CharacterTrait> EgoTraits { get; set; } = new List<CharacterTrait>();
    }

    public class CharacterSkill
    {
        public string Name { get; set; } = String.Empty;
        public int Rank { get; set; }
        public int Modifier { get; set; }
        public string Aptitude { get; set; } = String.Empty;
        public bool IsStandard { get; set; }
    }

    public class CharacterGear
    {
        public string Name { get; set; } = String.Empty;
        public string Summary { get; set; } = String.Empty;
        public int Quantity { get; set; }
        public bool Restricted { get; set; }
        public string Blueprint { get; set; } = String.Empty;
    }

    public class CharacterGearCache
    {
        public string Name { get; set; } = String.Empty;
        public string Location { get; set; } = String.Empty;
        public List<CharacterGear> CacheItems { get; set; } = new List<CharacterGear>();
    }

    public class CharacterTrait
    {
        public string Name { get; set; } = String.Empty;
        public int Level { get; set; }
        public string Summary { get; set; } = String.Empty;
    }

    public class CharacterMorph
    {
        public string Name { get; set; } = String.Empty;
        public int Cost { get; set; }
        public int Availability { get; set; }
        public string Type { get; set; } = String.Empty;
        public bool IsSynthMorph { get; set; }
        public string Size { get; set; } = String.Empty;
        public string Notes { get; set; } = String.Empty;

        //Pools
        public int Vigor { get; set; }
        public int Insight { get; set; }
        public int Moxie { get; set; }
        public int Flex { get; set; }

        //Resting
        public int ShortRest { get; set; }
        public int ShortRestMax { get; set; }
        public bool IsLongRestAvailable { get; set; }

        //Health
        public int Durability { get; set; }
        public int DurabilityModifier { get; set; }
        public int WoundThreshold => (Durability / 5) + WoundThresholdModifier;
        public int WoundThresholdModifier { get; set; }
        public int DeathRating => (int)(Durability * (IsSynthMorph ? 2 : 1.5)) + DeathRatingModifier;
        public int DeathRatingModifier { get; set; }
        public int Wounds { get; set; }

        //Movement
        public List<CharacterMorphMovementRates> MovementRates { get; set; } = new List<CharacterMorphMovementRates>(); 

        //Traits
        public List<CharacterTrait> Traits { get; set; } = new List<CharacterTrait>();

        //Ware
        public List<CharacterWare> Ware { get; set; } = new List<CharacterWare>();

        
    }

    public class CharacterMorphMovementRates
    {
        public string Type { get; set; } = String.Empty;
        public int Base { get; set; }
        public int Full { get; set; }
    }

    public class CharacterWare
    {
        public string Name { get; set; } = String.Empty;
        public string Type { get; set; } = String.Empty;
        public string Summary { get; set; } = String.Empty;
    }
}
