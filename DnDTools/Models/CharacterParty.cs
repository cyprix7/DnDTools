using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTools.Models
{
    public class CharacterParty : Character
    {
        public double Rations { get; set; }
        public int Gold { get; set; }

        public int SpellSlots1stLevel { get; set; }
        public int SpellSlots2ndLevel { get; set; }
        public int SpellSlots3rdLevel { get; set; }
        public int SpellSlots4thLevel { get; set; }
        public int SpellSlots5thLevel { get; set; }
        public int SpellSlots6thLevel { get; set; }
        public int SpellSlots7thLevel { get; set; }
        public int SpellSlots8thLevel { get; set; }
        public int SpellSlots9thLevel { get; set; }

        public int DeathSavingThrowSuccess { get; set; }
        public int DeathSavingThrowFailure { get; set; }
    }
}
