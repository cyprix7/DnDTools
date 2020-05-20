using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTools
{
    

    public class Character
    {
        public enum StatusTypes { Alive, Down, Dead };

        public int Id { get; set; }
        public string Name { get; set; }
        public StatusTypes Status { get; set; } = StatusTypes.Alive;
        public int Initiative { get; set; }
        public int HealthCurrent { get; set; }
        public int HealthMaximum { get; set; }
    }
}
