namespace DnDTools.Models
{
    public class CharacterParty : Character
    {
        public double Rations { get; set; }
        public int Gold { get; set; }

        public int SpellSlots1stLevelCurrent { get; set; }
        public int SpellSlots2ndLevelCurrent { get; set; }
        public int SpellSlots3rdLevelCurrent { get; set; }
        public int SpellSlots4thLevelCurrent { get; set; }
        public int SpellSlots5thLevelCurrent { get; set; }
        public int SpellSlots6thLevelCurrent { get; set; }
        public int SpellSlots7thLevelCurrent { get; set; }
        public int SpellSlots8thLevelCurrent { get; set; }
        public int SpellSlots9thLevelCurrent { get; set; }

        public int SpellSlots1stLevelMaximum { get; set; }
        public int SpellSlots2ndLevelMaximum { get; set; }
        public int SpellSlots3rdLevelMaximum { get; set; }
        public int SpellSlots4thLevelMaximum { get; set; }
        public int SpellSlots5thLevelMaximum { get; set; }
        public int SpellSlots6thLevelMaximum { get; set; }
        public int SpellSlots7thLevelMaximum { get; set; }
        public int SpellSlots8thLevelMaximum { get; set; }
        public int SpellSlots9thLevelMaximum { get; set; } 

        public int DeathSavingThrowSuccess { get; set; }
        public int DeathSavingThrowFailure { get; set; }
    }
}
